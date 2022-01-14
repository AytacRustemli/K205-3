using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2.Methods
{
    public class Endirim 
    {
        private int Price;

        //public int Endirimm()
        //{
        //    decimal result = Price - (Price * 20 / 100)
        //    return result();
        //}

        public int Endirimm() 
        {
            return Price - Price * 20 / 100;
        }
    }
}
