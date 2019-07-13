using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitBank_TestePratico_SilvioRodriguez.Classes
{
    class GlobalID
    {

        // Global ID that indexes all orders

        public static int idOrdering = 0;

        public static int getNextId()
        {
            idOrdering = idOrdering + 1;
            return idOrdering;
        }


    }
}
