using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBank_TestePratico_SilvioRodriguez.Classes
{
    public class OrderVO
    {

        // Attributes to create a order

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        private List<String> itens;

        public List<String> Itens
        {
            get { return itens; }
            set { itens = value; }
        }

        private int totalTime;

        public int TotalTime
        {
            get { return totalTime; }
            set { totalTime = value; }
        }

    }
}
