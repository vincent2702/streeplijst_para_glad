using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace streeplijst
{
    public partial class Prices : Form
    {
        private int item_id = 0;
        public Prices()
        {
            InitializeComponent();

            Fill_listbox();
        }

        private void Fill_listbox()
        {
            int i = 0;
            Itemsbox.Items.Clear();
            foreach (var item in FormList.OrderForm.dBConnect.price.Items)
            {
                String itemS = item + "\t" + FormList.OrderForm.dBConnect.price.Item_prices[i];
                if (item == "")
                {
                    itemS = "item" + i + "\t" + FormList.OrderForm.dBConnect.price.Item_prices[i];
                }
                Itemsbox.Items.Add(itemS);
                i++;

            }
        }

        private void Update_items_Click(object sender, EventArgs e)
        {
            //FormList.OrderForm.dBConnect.UpdateItemList(newItem.Text, comboBox1.SelectedIndex + 1, NewPrice.Value);
            
            //for (int i = 0; i < labels.Length; i++)
            //{
            //    labels[i].Text = x[i];
            //    textBoxes[i].Text = FormList.OrderForm.dBConnect.price.Items[i];
            //    numericUpDowns[i].Value = Convert.ToDecimal(FormList.OrderForm.dBConnect.price.Item_prices[i]);
            //}
        }
        

        private void Update_price_list_Click(object sender, EventArgs e)
        {
            String price = NewPrice.Value.ToString().Replace(',', '.');
            FormList.OrderForm.dBConnect.UpdateItemList(newItem.Text,item_id, price);
            FormList.OrderForm.dBConnect.PriceList();
            Fill_listbox();
            //this.Close();
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    newItem.Text = FormList.OrderForm.dBConnect.price.Items[comboBox1.SelectedIndex];
        //}

        private void Itemsbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newItem.Text = FormList.OrderForm.dBConnect.price.Items[Itemsbox.SelectedIndex];
            NewPrice.Value = Convert.ToDecimal(FormList.OrderForm.dBConnect.price.Item_prices[Itemsbox.SelectedIndex]);
            item_id = Itemsbox.SelectedIndex + 1;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
