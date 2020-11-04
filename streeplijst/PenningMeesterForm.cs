using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using streeplijst_library;

namespace streeplijst
{
    public partial class PenningMeesterForm : Form
    {
        
        public PenningMeesterForm()
        {
            InitializeComponent();
            //this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

        }

        private void Afsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Incasso_Click(object sender, EventArgs e)
        {
            if(MsgBox.Show("weet je het zeker", "", "JA", "NEE") == DialogResult.Yes)
            {
                FormList.OrderForm.dBConnect.Register_to_CSV();
                FormList.OrderForm.dBConnect.TotalLijst_to_CSV();
                FormList.OrderForm.dBConnect.ResetDATA("streeplijst", "Item1", "Item2", "Item3", "Item4", "Item5", "Item6", "Item7", "Item8", "Item9", "Item10");
                FormList.OrderForm.dBConnect.ResetDATA("register");
                
            }
        }

        private void Add_person_Click(object sender, EventArgs e)
        {
            AddPerson addPerson = new AddPerson();
            addPerson.Show();
        }

        private void Remove_person_Click(object sender, EventArgs e)
        {
            AddDeletePerson deletePerson = new AddDeletePerson();
            deletePerson.Show();
        }

        private void Change_price_Click(object sender, EventArgs e)
        {
            Prices prices = new Prices();
           
            prices.Show();
        }

        private void Terug_Click(object sender, EventArgs e)
        {
            FormList.NameListForm.Show();
            FormList.PenningMeesterForm.Hide();
            FormList.NameListForm.textBox1.Text = "";
        }

        private void Streepen_Click(object sender, EventArgs e)
        {
            FormList.PenningMeesterForm.Hide();
            FormList.OrderForm.Show();
            FormList.OrderForm.FullName = "penning\tmeester";
            FormList.OrderForm.GetData();
            FormList.OrderForm.timer1.Start();
        }

        private void Stock_Update_Click(object sender, EventArgs e)
        {
            StockFrom stock = new StockFrom();
            stock.Show();
        }

        private void Persoon_info_Click(object sender, EventArgs e)
        {
            PersonData person = new PersonData();
            person.Show();
        }

        private void Remove_Add_person_Click(object sender, EventArgs e)
        {
            AddDeletePerson addDeletePerson = new AddDeletePerson();
            addDeletePerson.Show();
        }

        private void Start_jaar_Click(object sender, EventArgs e)
        {
            if (MsgBox.Show("weet je het zeker", "", "JA", "NEE") == DialogResult.Yes)
            {
                FormList.OrderForm.dBConnect.ResetDATA("streeplijst_total", "Item12", "Item22", "Item32", "Item42", "Item52", "Item62", "Item72", "Item82", "Item92", "Item102");
                FormList.OrderForm.dBConnect.ResetDATA("teams", "Bier_count");
                FormList.OrderForm.dBConnect.ResetDATA("commissies", "Bier_count");
                FormList.OrderForm.dBConnect.ResetDATA("maandelijks", "Item111");

            }
        }
    }
}
