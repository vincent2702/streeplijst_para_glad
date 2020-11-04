using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using streeplijst_library;

namespace streeplijst
{
    public partial class PersonData : Form
    {
        BindingSource ledenBinding = new BindingSource();
        public PersonData()
        {
            InitializeComponent();
            
        }

        private void Update_List()
        {

            SerachBox.Focus();
            this.ActiveControl = SerachBox;
            ledenBinding.DataSource = FormList.OrderForm.dBConnect.Names.Leden;
            Names.DataSource = null;
            Names.DataSource = ledenBinding;

            Names.DisplayMember = "Display";
            Names.ValueMember = "Display";
        }


        private String[] data = {"", "", "", "", "", "", "", "", "", "" };
        private int[] x = {0,0,0,0,0,0,0,0,0,0};
        private int[] y = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int index = 0;

        private void Update_Click(object sender, EventArgs e)
        {
            if (label3.Text == "team")
            {
                FormList.OrderForm.dBConnect.Update("teams_has_nameslist", int.Parse(ID.Text), (int)numericUpDown1.Value, 12);
            }
            else
            {
                y[index - 1] = y[index - 1] - (x[index] - (int)numericUpDown1.Value);
                FormList.OrderForm.dBConnect.Update("Item" + index, int.Parse(ID.Text), (int)numericUpDown1.Value, "streeplijst");
                FormList.OrderForm.dBConnect.Update("Item" + index + "2", int.Parse(ID.Text), y[index-1], "streeplijst_total");

            }

            FormList.OrderForm.dBConnect.SearchDB(FullName.Text);
            Data_person.Items.Clear();
            Update_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormList.OrderForm.dBConnect.Update("teams_has_nameslist", Convert.ToInt16(ID.Text), Convert.ToInt16(Team.Text), Convert.ToInt16(Commissie.Text));
            this.Close();
        }

        private void SerachBox_TextChanged(object sender, EventArgs e)
        {
            var x = SerachBox.Text;
            FormList.OrderForm.dBConnect.Nameslist(x);
            Update_List();
        }

        private void Update_data()
        {
            String LidS = "";
            int i = 0;
            foreach (Lid leden in FormList.OrderForm.dBConnect.lijst.Leden)
            {
                LidS = "Team \t" + leden.Team;
                FullName.Text = leden.Firstname + "\t" + leden.Lastname;
                ID.Text = leden.Number.ToString();
                Data_person.Items.Add(LidS);
                data[i] = "team";
                x[i] = Int16.Parse(leden.Team);
            }
            foreach (var item in FormList.OrderForm.dBConnect.price.Items)
            {
                foreach (Item itemCount in FormList.OrderForm.dBConnect.lijst.Items)
                {
                    if (item != "")
                    {
                        LidS = item + "\t" + itemCount.ItemCountTotal[i].ToString();
                        Data_person.Items.Add(LidS);
                        x[i + 1] = itemCount.ItemCountTotal[i];
                        y[i] = itemCount.ItemCountTotal2[i];
                    }
                }
                if (item == "")
                {
                    break;
                }
                data[i + 1] = item;
                i++;

            }
        }


        private void Names_MouseClick(object sender, MouseEventArgs e)
        {
            Data_person.Items.Clear();
            FormList.OrderForm.dBConnect.SearchDB(Names.SelectedValue.ToString());
            Update_data();

        }

        private void Data_person_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Text = data[Data_person.SelectedIndex];
            index = Data_person.SelectedIndex;
            numericUpDown1.Value = x[Data_person.SelectedIndex];
        }
    }
}
