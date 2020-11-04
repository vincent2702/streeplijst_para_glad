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
    public partial class AddDeletePerson : Form
    {
        private BindingSource ledenBinding = new BindingSource();
        public AddDeletePerson()
        {
            InitializeComponent();
            Team.Text = "8";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var x = textBox1.Text;
            FormList.OrderForm.dBConnect.Nameslist(x);
            Update_List();
        }

        private void Update_List()
        {

            textBox1.Focus();
            this.ActiveControl = textBox1;
            ledenBinding.DataSource = FormList.OrderForm.dBConnect.Names.Leden;
            Names.DataSource = null;
            Names.DataSource = ledenBinding;

            Names.DisplayMember = "Display";
            Names.ValueMember = "Display";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            string x = Names.SelectedValue.ToString();
            int id = 0;
            foreach (Lid lid in FormList.OrderForm.dBConnect.lijst.Leden)
            {
                if (x.ToLower() == lid.Firstname.ToLower() + "\t" + lid.Lastname.ToLower())
                {
                    id = lid.Items.Id;
                }
            }
            if (id != 0)
            {
                FormList.OrderForm.dBConnect.DeletPerson(id);

            }
            textBox1.Clear();

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (firstName.Text != "" && lastName.Text != "")
            {
                FormList.OrderForm.dBConnect.AddPerson(firstName.Text, lastName.Text);
                FormList.OrderForm.dBConnect.AddStreeplijstData(firstName.Text, lastName.Text, Team.Text, "12");
                firstName.Clear();
                lastName.Clear();
                Team.Clear();

            }
            else
            {
                Console.Beep();
            }
        }

        private void Terug_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
