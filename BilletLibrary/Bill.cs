using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLibrary
{
    public class Bill
    {
        //Properties
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }

        //Methods
        public int Pris(int pris)
        {
            return pris;
        }

        public string Køretøj()
        {
            return "Bil";
        }

    }
}
