using System;
using System.Collections.Generic;
using System.Text;

namespace streeplijst_library
{
    public class PriceList
    {
        public Double[] Item_prices { get; set; } = new double[10];
        public String[] Items { get; set; } = new string[10];

        public PriceList()
        {

        }
    }
}
