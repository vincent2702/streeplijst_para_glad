using System;
using System.Collections.Generic;
using System.Text;

namespace streeplijst_library
{
    public class Item
    {



        public int[] ItemCount { get; set; } = new int[10];

        public int[] ItemCountTotal { get; set; } = new int[10];

        public int[] ItemCountTotal2 { get; set; } = new int[10];

        public int ItemCountMaandelijks { get; set; }


        public int Id { get; set; }



        public Item()
        {
            Id = 0;
            //ItemCount = 0;
            //ItemCountTotal = 0;

        }
    }
}
