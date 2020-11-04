using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using streeplijst_library;
using System.Resources;


namespace streeplijst
{
    public partial class OrderForm : Form
    {

        /*
        *
        * lijst is a List of items and Names 
        * The intergers are for adding and decreasing the items counts
        * fullName is a public String with a get and set so form to can change the variable.
        */
        //public Lijst lijst = new Lijst();
        public DBConnect dBConnect = new DBConnect();
        public Quotes quotes = new Quotes();


        int[] itemCount, TotalItemCount, TotalItemCount2;
        Double[] TotalPriceItem;
        int id;
        string teamID, commissieID;


        Button[] Buttons_plus, Buttons_min;
        public String FullName { get; set; }
        /*
         * OrderForm starts the first interface. sets up the data and calls the UpdatText method 
         * */
        public OrderForm()
        {
            InitializeComponent();
            listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            //this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            

            //SetUpData();
            //dBConnect.SearchDB("");
            dBConnect.Nameslist("");
            dBConnect.PriceList();

            itemCount = new int[10];
            TotalItemCount = new int[10];
            TotalItemCount2 = new int[10];
            TotalPriceItem = new Double[10];
            Buttons_plus = new Button[] { Item1, Item2, Item3, Item4, Item5, Item6 };
            Buttons_min = new Button[] { Item01, Item02, Item03, Item04, Item05, Item06 };
            //UpdateText();

        }

        public void GetData()
        {
            int i = 0;
            foreach (var button in Buttons_plus)
            {
                if (dBConnect.price.Items[i] != "")
                {
                    button.Text = dBConnect.price.Items[i] + "+";
                    Buttons_min[i].Text = dBConnect.price.Items[i] + "-";
                    button.FlatAppearance.BorderSize = 2;
                    Buttons_min[i].FlatAppearance.BorderSize = 2;
                    button.FlatAppearance.BorderColor = Color.FromArgb(82, 49,143);
                    Buttons_min[i].FlatAppearance.BorderColor = Color.FromArgb(82, 49, 143);

                    switch (dBConnect.price.Items[i].ToLower())
                    {
                        case "bier":
                            button.Image = Resources.Resource1.Bier1;
                            Buttons_min[i].Image = Resources.Resource1.Bier1;
                            break;
                        case "fris":
                            button.Image = Resources.Resource1.Fris;
                            Buttons_min[i].Image = Resources.Resource1.Fris;
                            break;
                        case "wijn":
                            button.Image = Resources.Resource1.Wijn;
                            Buttons_min[i].Image = Resources.Resource1.Wijn;
                            break;
                        case "snoep":
                            button.Image = Resources.Resource1.Snoep;
                            Buttons_min[i].Image = Resources.Resource1.Snoep;
                            break;
                        case "aa":
                            //button.Image = Resources.Resource1.AA;
                            //Buttons_min[i].Image = Resources.Resource1.AA;
                            break;
                        default:
                            button.BackColor = Color.LightGray;
                            Buttons_min[i].BackColor = Color.LightGray;
                            break;
                    }
                }
                else
                {
                    button.Text = "";
                    Buttons_min[i].Text = "";
                    button.BackColor = Color.FromArgb(82, 49, 143);
                    Buttons_min[i].BackColor = Color.FromArgb(82, 49, 143);
                    button.FlatAppearance.BorderSize = 0;
                    Buttons_min[i].FlatAppearance.BorderSize = 0;

                }
                i++;

            }
            name.Text = FullName;
            dBConnect.SearchDB(FullName);

            foreach (Lid lid in dBConnect.lijst.Leden)
            {
                if (name.Text.ToLower() == lid.Firstname.ToLower() + "\t" + lid.Lastname.ToLower())
                {
                    for (int j = 0; j < TotalItemCount.Length; j++)
                    {
                        itemCount[j] = lid.Items.ItemCount[j];
                        TotalItemCount[j] = lid.Items.ItemCountTotal[j];
                        TotalItemCount2[j] = lid.Items.ItemCountTotal2[j];

                    }
                    id = lid.Items.Id;
                    teamID = lid.Team;
                    commissieID = lid.Commissies;

                }
            }
        }
        double sumTotalPrice = 0;

        private void UpdateText()
        {
            for (int j = 0; j < TotalPriceItem.Length; j++)
            {
                TotalPriceItem[j] = itemCount[j] * dBConnect.price.Item_prices[j];
            }
            sumTotalPrice = TotalPriceItem.Sum();
            listView1.Items.Clear();
            int i = 0;
            foreach (var item in dBConnect.price.Items)
            {
                if (item != "")
                {
                    string[] row = { item, itemCount[i].ToString()};
                    var item1 = new ListViewItem(row);
                    listView1.Items.Add(item1);
                }
                i++;
            }
        }
            
       
        private void Main_Click(object sender, EventArgs e)
        {
            Button x = sender as Button;
            if (x.Text != "")
            {
                switch (x.Name)
                {
                    case "Item1":
                        itemCount[0]++;
                        break;
                    case "Item01":
                        itemCount[0]--;
                        if (itemCount[0] < 0)
                        {
                            itemCount[0] = 0;
                        }
                        break;
                    case "Item2":
                        itemCount[1]++;
                        break;
                    case "Item02":
                        itemCount[1]--;
                        if (itemCount[1] < 0)
                        {
                            itemCount[1] = 0;
                        }
                        break;
                    case "Item3":
                        itemCount[2]++;
                        break;
                    case "Item03":
                        itemCount[2]--;
                        if (itemCount[2] < 0)
                        {
                            itemCount[2] = 0;
                        }
                        break;
                    case "Item4":
                        itemCount[3]++;
                        break;
                    case "Item04":
                        itemCount[3]--;
                        if (itemCount[3] < 0)
                        {
                            itemCount[3] = 0;
                        }
                        break;
                    case "Item5":
                        itemCount[4]++;
                        break;
                    case "Item05":
                        itemCount[4]--;
                        if (itemCount[4] < 0)
                        {
                            itemCount[4] = 0;
                        }
                        break;
                    case "Item6":
                        itemCount[5]++;
                        break;
                    case "Item06":
                        itemCount[5]--;
                        if (itemCount[5] < 0)
                        {
                            itemCount[5] = 0;
                        }
                        break;
                    case "Item7":
                        itemCount[6]++;
                        break;
                    case "Item07":
                        itemCount[6]--;
                        if (itemCount[6] < 0)
                        {
                            itemCount[6] = 0;
                        }
                        break;
                    case "Item8":
                        itemCount[7]++;
                        break;
                    case "Item08":
                        itemCount[7]--;
                        if (itemCount[7] < 0)
                        {
                            itemCount[7] = 0;
                        }
                        break;
                    case "Item9":
                        itemCount[8]++;
                        break;
                    case "Item09":
                        itemCount[8]--;
                        if (itemCount[8] < 0)
                        {
                            itemCount[8] = 0;
                        }
                        break;
                    case "Item10":
                        itemCount[9]++;
                        break;
                    case "Item010":
                        itemCount[9]--;
                        if (itemCount[9] < 0)
                        {
                            itemCount[9] = 0;
                        }
                        break;
                    default:
                        break;
                }
            }
            UpdateText();

        }

        Random rnd = new Random();
        int[] a = new int[] { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 660, 700, 750, 800, 850, 900, 950, 1000 };
        private void Klaar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            string x;
            int Bier = 0, Fris = 0, Snoep = 0, AA = 0;
            int y = 0, j = 0;


            foreach (var Item in dBConnect.price.Items)
            {
                if (Item == "Bier")
                {
                    Bier = itemCount[y];
                    j = y;
                }
                else if (Item == "Fris")
                {
                    Fris = itemCount[y];
                }
                else if (Item == "Snoep")
                {
                    Snoep = itemCount[y];
                }
                else if (Item == "AA")
                {
                    AA = itemCount[y];
                }
                
                y++;
            }
                switch (Bier)
            {
                case 1:
                    int num = rnd.Next(1, 4);
                    if (Fris == 2) { x = quotes.quote7; } //Aan het verdunnen?
                    else if (Fris == 1) { x = quotes.quote8; } //Wil je me vergifitigen ofzo?
                    else if (num == 1) { x = quotes.quote1; } //We drinken niet allee
                    else if (num == 3) { x = quotes.quote18; }
                    else { x = quotes.quote12; } // ERROR
                    break;
                case 3: 
                    if (Snoep == 1) { x = quotes.quote6; } //KILLER COMBO
                    else { x = quotes.quote2; } // BierPong?
                    break;
                case 5:
                    x = quotes.quote5;
                    break;
                case 8:
                    x = quotes.quote9; //SPARE
                    break;
                case 10:
                    x = quotes.quote10; //SPARE
                    break;
                default:
                    if (Bier > 10) { x = quotes.quote11; }
                    else { x = "weet je het zeker"; }
                    break;
            }
            if (AA > 0)
            {
                int num = rnd.Next(1, 4);
                switch (num)
                {
                    case 1:
                        x = quotes.quote15;
                        break;
                    case 2:
                        x = quotes.quote16;
                        break;
                    case 3:
                        x = quotes.quote17;
                        break;
                    default:
                        break;
                }

            }


            //for (int i = 0; i < a.Length; i++)
            //{
            //if ((TotalBierCount2 + BierCount) == a[i]) { x = quotes.quote14 + (TotalBierCount2 + BierCount) + " BIER";}
            //}



            if (MsgBox.Show(x, "", "JA", "NEE") == DialogResult.Yes)
            {
               
                FormList.StartForm.Show();
                //FormList.NameListForm.Show();
                FormList.OrderForm.Hide();


                dBConnect.UpdateStock(itemCount[0], itemCount[1], itemCount[2], itemCount[3], itemCount[4], itemCount[5], itemCount[6], itemCount[7], itemCount[8], itemCount[9]);
                dBConnect.UpdateTeamAndCommissie(teamID, commissieID, itemCount[j]);
                dBConnect.Update_maandelijks(itemCount[j], id);

                for (int i = 0; i < TotalItemCount.Length; i++)
                {
                    TotalItemCount[i] += itemCount[i];
                    TotalItemCount2[i] += itemCount[i];
                    itemCount[i] = 0;
                }
                


                dBConnect.Update("streeplijst", TotalItemCount[0], TotalItemCount[1], TotalItemCount[2], TotalItemCount[3], TotalItemCount[4],
                                TotalItemCount[5], TotalItemCount[6], TotalItemCount[7], TotalItemCount[8], TotalItemCount[9], id);


                dBConnect.Update("streeplijst_total", TotalItemCount2[0], TotalItemCount2[1], TotalItemCount2[2], TotalItemCount2[3], TotalItemCount2[4],
                                TotalItemCount2[5], TotalItemCount2[6], TotalItemCount2[7], TotalItemCount2[8], TotalItemCount2[9], id);

                dBConnect.InsertRegister(id.ToString(), FullName.Substring(0, FullName.IndexOf('\t')), FullName.Substring(FullName.IndexOf('\t') + 1),
                                        TotalPriceItem[0].ToString(), TotalPriceItem[1].ToString(), TotalPriceItem[2].ToString(), TotalPriceItem[3].ToString(), TotalPriceItem[4].ToString(),
                                        TotalPriceItem[5].ToString(), TotalPriceItem[6].ToString(), TotalPriceItem[7].ToString(), TotalPriceItem[8].ToString(), TotalPriceItem[9].ToString(),
                                        sumTotalPrice.ToString(), DateTime.Now.ToString("dd/MM/yyyy H:mm"));


                dBConnect.SearchDB("");
                FormList.NameListForm.Update_List();
                FormList.StartForm.List_Update();
                timer1.Stop();

                UpdateText();
                
            }
        }

        private void terug_Click(object sender, EventArgs e)
        {
            FormList.NameListForm.Show();
            FormList.OrderForm.Hide();
            for (int i = 0; i < TotalItemCount.Length; i++)
            {
                itemCount[i] = 0;
            }
            FormList.NameListForm.Update_List();
            //FormList.StartForm.Show();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
