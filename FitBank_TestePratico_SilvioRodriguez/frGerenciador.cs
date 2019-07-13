using FitBank_TestePratico_SilvioRodriguez.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitBank_TestePratico_SilvioRodriguez
{
    public partial class frGerenciador : Form
    {

        // Initializing Components...
        public frGerenciador()
        {
            InitializeComponent();

        }

        // Loads the form
        // Creates a new instance of Order's List
        // Adds the first log activity
        private void Form1_Load(object sender, EventArgs e)
        {
            buildMenu();
            Classes.GlobalOrders.allOrders = new List<Classes.OrderVO>();
            addLog("Olá, Bem-Vindo! Este é o Gerenciador de Pedidos da FitBank, aqui você pode acompanhar o log das atividades...");
        }

        // Method to add log activities
        private void addLog(string msg)
        {
            lbLogging.Items.Add(msg);
            lbLogging.SelectedIndex = lbLogging.Items.Count - 1;

        }

        // Reads the menu.txt file from embedded resources and mount the menu to listbox
        private void buildMenu()
        {
            try
            {

                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "FitBank_TestePratico_SilvioRodriguez.Asset.menu.txt";

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string product = line.Split('|')[0];
                        string time = line.Split('|')[1];
                        lbMenu.Items.Add(product + " (" + time + ") ");
                    }
                }

            }
            catch (ArgumentNullException error)
            {
                MessageBox.Show("Arquivo não encontrado: " + error.Message);
            }


        }

        // Event to add menu item to order itens
        private void lbMenu_DoubleClick(object sender, EventArgs e)
        {
            if (lbMenu.SelectedItem != null)
            {
                lbOrderItens.Items.Add(lbMenu.GetItemText(lbMenu.SelectedItem));
            }
        }

        // Click to clear all order itens
        private void btnCleanOrder_Click(object sender, EventArgs e)
        {
            lbOrderItens.Items.Clear();
        }

        // Click to confirm the order
        private void btnConfirmOrder_Click(object sender, EventArgs e)
        {

            try
            {

                if (lbOrderItens.Items.Count == 0)
                {
                    throw new ArgumentNullException("Não é possivel criar um pedido vazio");
                }

                if (txtCustomerName.TextLength == 0)
                {
                    throw new ArgumentNullException("Insira o nome do cliente para criar o pedido");
                }

                if (!Regex.IsMatch(txtCustomerName.Text, @"^[a-zA-Z]+$"))
                {
                    throw new InvalidOperationException("Insira apenas letras no nome.");
                }

                OrderVO order = Classes.Ordering.createOrder(txtCustomerName.Text, lbOrderItens.Items.Cast<String>().ToList());

                OrderDAO.insertOrder(order);

                updateOrder(lbQueue, order);

                addLog("Pedido do " + order.CustomerName + " adicionado. O nº do pedido é: " + order.Id);

                txtCustomerName.Text = "";
                lbOrderItens.Items.Clear();

            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show(error.Message);
            }
            catch (ArgumentNullException error)
            {
                MessageBox.Show(error.ParamName);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        // Logo redirects to the FitBank WebSite on Default WebBrowser
        private void pbLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.fitbank.com.br/");
        }

        // Click to remove selected item from order itens
        private void lbOrderItens_DoubleClick(object sender, EventArgs e)
        {
            if (lbOrderItens.SelectedItem != null)
            {
                lbOrderItens.Items.Remove(lbMenu.GetItemText(lbOrderItens.SelectedItem));
            }
        }

        // Updates the orders from status' panels
        private void updateOrder(ListBox toList, OrderVO order)
        {
            toList.Items.Add(order.Id + ": " + order.CustomerName + " - " + order.TotalTime);
        }

        // Starts the ticking event from timer to process the orders
        private void timer_Tick(object sender, EventArgs e)
        {
            if (lbQueue.Items.Count != 0 || lbStartedOrders.Items.Count != 0 || lbFinishedOrders.Items.Count != 0)
            {
                pbStatus.Image = global::FitBank_TestePratico_SilvioRodriguez.Properties.Resources.loading;

                updateQueues(lbQueue, lbStartedOrders);
                updateQueues(lbStartedOrders, lbFinishedOrders);
                updateQueues(lbFinishedOrders, lbDeliveredOrders);
                updateQueues(lbDeliveredOrders);

            }
            else
            {
                pbStatus.Image = global::FitBank_TestePratico_SilvioRodriguez.Properties.Resources.done;
            }
        }

        // Updates all queues
        private void updateQueues(ListBox from, ListBox to = null)
        {
            switch (from.Name)
            {
                case "lbQueue":

                    if (lbQueue.Items.Count == 0 || lbStartedOrders.Items.Count >= 4)
                        return;
                    else
                    {
                        do
                        {
                            lbStartedOrders.Items.Add(lbQueue.Items[0]);
                            OrderVO hasOrder = Classes.GlobalOrders.allOrders.Single(cus => cus.Id == Convert.ToInt16(lbQueue.Items[0].ToString().Substring(0, lbQueue.Items[0].ToString().IndexOf(':'))));
                            addLog("O pedido de " + hasOrder.CustomerName + " foi atualizado para Iniciado.");
                            lbQueue.Items.RemoveAt(0);

                        } while (lbStartedOrders.Items.Count < 4 && lbQueue.Items.Count > 0);
                    }

                    break;

                case "lbStartedOrders":

                    List<int> idUpdateList = new List<int>();

                    for (int n = 0; n < lbStartedOrders.Items.Count; n++)
                    {
                        int curTime = Convert.ToInt32(lbStartedOrders.Items[n].ToString().Substring(lbStartedOrders.Items[n].ToString().IndexOf('-') + 1));

                        if (curTime == 1)
                            idUpdateList.Add(Convert.ToInt16(lbStartedOrders.Items[n].ToString().Substring(0, lbStartedOrders.Items[n].ToString().IndexOf(':'))));
                        else
                        {
                            lbStartedOrders.Items[n] = lbStartedOrders.Items[n].ToString().Substring(0, lbStartedOrders.Items[n].ToString().IndexOf('-') + 1) + " " + (curTime - 1).ToString();
                        }
                    }

                    foreach (int id in idUpdateList)
                    {
                        List<String> listBoxList = lbStartedOrders.Items.Cast<string>().ToList();
                        int pos = listBoxList.FindIndex(c => Convert.ToInt32(c.Substring(0, c.IndexOf(':'))) == id);
                        
                        lbFinishedOrders.Items.Add(lbStartedOrders.Items[pos].ToString().Substring(0, lbStartedOrders.Items[pos].ToString().IndexOf('-')));
                        OrderVO hasOrder = Classes.GlobalOrders.allOrders.Single(cus => cus.Id == Convert.ToInt16(lbStartedOrders.Items[pos].ToString().Substring(0, lbStartedOrders.Items[pos].ToString().IndexOf(':'))));
                        addLog("O pedido de " + hasOrder.CustomerName + " foi atualizado para Finalizado.");
                        lbStartedOrders.Items.Remove(lbStartedOrders.Items[pos]);
                    }

                    break;

                case "lbFinishedOrders":

                    if (lbFinishedOrders.Items.Count > 0)
                    {
                        lbDeliveredOrders.Items.Add(lbFinishedOrders.Items[0].ToString());
                        OrderVO found = Classes.GlobalOrders.allOrders.Single(cus => cus.Id == Convert.ToInt16(lbFinishedOrders.Items[0].ToString().Substring(0, lbFinishedOrders.Items[0].ToString().IndexOf(':'))));
                        addLog("O pedido de " + found.CustomerName + " foi Entregue.");
                        lbFinishedOrders.Items.RemoveAt(0);
                    }

                    break;

                case "lbDeliveredOrders":

                    break;
            }
        }

        // Method to show details from the delivered order
        private void lbDeliveredOrders_DoubleClick(object sender, EventArgs e)
        {
            if (lbDeliveredOrders.SelectedItem != null)
            {
                //lbDeliveredOrders.SelectedItem.ToString();

                int id = Convert.ToInt32(lbDeliveredOrders.SelectedItem.ToString().Substring(0, lbDeliveredOrders.SelectedItem.ToString().IndexOf(':')));
                OrderVO order = GlobalOrders.allOrders.Single<OrderVO>(o => o.Id == id);

                string orderDescription = "#" + order.Id + " " + order.CustomerName + Environment.NewLine + "Itens do pedido:" + Environment.NewLine;

                foreach (string item in order.Itens)
                    orderDescription += item + Environment.NewLine;

                MessageBox.Show(orderDescription);

            }
        }

        // Menu Tooltip
        private void lblMenu_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Basta clicar duas vezes em qualquer \r\n item para adicionar ao pedido.", lblMenu, 5000);
        }

        // Menu Tooltip
        private void lblSelectedItens_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Basta clicar duas vezes em qualquer \r\n item para remover do pedido.", lblSelectedItens, 5000);
        }

        // Queue Tooltip
        private void gbQueue_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Pedidos aguardando processamento.", gbQueue, 5000);
        }

        // StartedOrders Tooltip
        private void gbStartedOrders_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Pedidos em processamento.", gbStartedOrders, 5000);
        }

        // FinishedOrders Tooltip
        private void gbFinishedOrders_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Pedidos finalizados.", gbFinishedOrders, 5000);
        }

        // DeliveredOrders Tooltip
        private void gbDeliveredOrders_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Pedidos entregues.", gbDeliveredOrders, 5000);
        }

        // Log Tooltip
        private void gbLog_MouseHover(object sender, EventArgs e)
        {
            toolTip.Show("Log das atividades.", gbLog, 5000);
        }

    }
}
