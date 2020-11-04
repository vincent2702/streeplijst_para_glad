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
using System.Collections;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;
using streeplijst.Properties;
using System.Configuration;

namespace streeplijst
{
    public partial class StartForm : Form
    {
        

        public StartForm()
        {
            InitializeComponent();
            
           // this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            DateTime dateTime = DateTime.Today;
            //Properties.Settings.Default.Reset();
            //int x = Properties.Settings.Default.maand;
            if (dateTime.Month == Properties.Settings.Default.maand)
            {
                FormList.OrderForm.dBConnect.ResetMontly();

                if (Properties.Settings.Default.maand == 12)
                {
                    Properties.Settings.Default.maand = 1;
                }
                else { Properties.Settings.Default.maand += 1; }

                Properties.Settings.Default.Save();
            }
            List_Update();
        }
        

        private void StartForm_MouseClick(object sender, MouseEventArgs e)
        {

            FormList.OrderForm.dBConnect.Nameslist("");
            FormList.NameListForm.textBox1.Clear();
            FormList.NameListForm.textBox1.Focus();
            FormList.NameListForm.ShowOnScreenKeyboard();

            FormList.NameListForm.Show();
            FormList.StartForm.Hide();
        }
        public void Formchange() {
            
        }
        private void Change()
        {
            FormList.StartForm.Hide();
        }
        
        public void List_Update()
        {
            int[] teams = new int[] { 0, 0, 0, 0, 0, 0, 0 };
            int[] commisies = new int[] { 0, 0, 0, 0, 0, 0, 0,0,0,0,0 };
            bierlijst.Items.Clear();
            maandelijks.Items.Clear();
            FormList.OrderForm.dBConnect.SearchDB("");
            int j = 0, i = 0;
            foreach (var item in FormList.OrderForm.dBConnect.price.Items)
            {
                if (item == "Bier")
                {
                    break;
                }
                i++;
            }
            FormList.OrderForm.dBConnect.lijst.Leden.Sort((x, y) => y.Items.ItemCountTotal2[i].CompareTo(x.Items.ItemCountTotal2[i]));
            ListViewItem itm;
            foreach (Lid lid in FormList.OrderForm.dBConnect.lijst.Leden)
            {
                j++;
                String[] arr1 = new string[4];
                

                arr1[0] = lid.Firstname.ToString();
                arr1[1] = lid.Lastname.ToString();
                arr1[2] = lid.Items.ItemCountTotal2[i].ToString();
                arr1[3] = j.ToString();

                itm = new ListViewItem(arr1);
                bierlijst.Items.Add(itm);

                lid.Number = j;

            }
            j = 0;
            FormList.OrderForm.dBConnect.lijst.Leden.Sort((x, y) => y.Items.ItemCountMaandelijks.CompareTo(x.Items.ItemCountMaandelijks));
            foreach (Lid lid in FormList.OrderForm.dBConnect.lijst.Leden)
            {
                j++;
                String[] arr2 = new string[4];

                arr2[1] = lid.Firstname.ToString();
                arr2[2] = lid.Lastname.ToString();
                arr2[3] = lid.Items.ItemCountMaandelijks.ToString();
                arr2[0] = j.ToString();

                itm = new ListViewItem(arr2);
                maandelijks.Items.Add(itm);

                lid.Number = j;
            }



            j = 0;

            FormList.OrderForm.dBConnect.TopTeams();
            bier_teams.Items.Clear();
            foreach (Teams team in FormList.OrderForm.dBConnect.teams_bier.Teams)
            {
                if (team.Team != "De parabool 0" && team.Team != "De parabool 7")
                {
                    String[] arr = new string[2];
                    
                    arr[0] = team.Team;
                    arr[1] = team.Bier_count.ToString();
                    itm = new ListViewItem(arr);
                    bier_teams.Items.Add(itm);
                }
            }

            
            FormList.OrderForm.dBConnect.TopCommissies();
            //CommissieBier.Items.Clear();
            //foreach (Teams team in FormList.OrderForm.dBConnect.teams_bier.Teams)
            //{
            //    if (team.Commissie != "geen")
            //    {
            //        String[] arr = new string[2];
            //        ListViewItem itm;
            //        arr[0] = team.Commissie;
            //        arr[1] = team.Bier_count.ToString();
            //        itm = new ListViewItem(arr);
            //        CommissieBier.Items.Add(itm);
            //    }
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
