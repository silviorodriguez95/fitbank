using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBank_TestePratico_SilvioRodriguez.Classes
{
    class Ordering
    {

        // Creates order object with selected itens

        public static OrderVO createOrder(string customerName, List<string> itens)
        {
            OrderVO newOrder = new OrderVO();
            newOrder.Id = Classes.GlobalID.getNextId();
            newOrder.CustomerName = customerName;

            int countOcurrences = (from n in itens where n.Contains("Hamburguer") select n).Count();
            if (countOcurrences == 2)
                itens.Add("Suco (5)");

                newOrder.Itens = itens;

            int totalTime = 0;
            foreach (string item in itens)
            {
                int startPos = item.IndexOf("(") + 1;
                int finalPos = item.LastIndexOf(")");
                totalTime += Convert.ToInt32(item.Substring(startPos, finalPos - startPos));
            }
                
            newOrder.TotalTime = totalTime;
            return newOrder;
        }

    }
}
