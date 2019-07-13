using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using FitBank_TestePratico_SilvioRodriguez.Properties;

namespace FitBank_TestePratico_SilvioRodriguez.Classes
{
    class OrderDAO
    {

        // Adds the order into Global Order List
        
        public static void insertOrder(OrderVO order)
        {
            if (Classes.GlobalOrders.allOrders == null)
                throw new ArgumentNullException("Lista de Pedidos não iniciada");

            Classes.GlobalOrders.allOrders.Add(order);

        }

    }
}
