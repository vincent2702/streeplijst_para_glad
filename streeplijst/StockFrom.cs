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
    public partial class StockFrom : Form
    {
        DBConnect dB = new DBConnect();
        String[] x = new String[10];
        public StockFrom()
        {
            InitializeComponent();

            x = dB.Total_Sold();
            Old_Bier_Count.Text = x[5];
            Old_Fris_Count.Text = x[6];
            Old_Wijn_Count.Text = x[7];
            Old_Snoep_Count.Text = x[8];
            Old_AA_Count.Text = x[9];

            Bier_sold.Text = x[0];
            Fris_sold.Text = x[1];
            Wijn_sold.Text = x[2];
            Snoep_sold.Text = x[3];
            AA_sold.Text = x[4];
            
            Bier_Huidig.Text = (Int32.Parse(x[5]) - Int32.Parse(x[0])).ToString();
            Fris_Huidig.Text = (Int32.Parse(x[6]) - Int32.Parse(x[1])).ToString();
            Wijn_Huidig.Text = (Int32.Parse(x[7]) - Int32.Parse(x[2])).ToString();
            Snoep_Huidig.Text = (Int32.Parse(x[8]) - Int32.Parse(x[3])).ToString();
            AA_Huidig.Text = (Int32.Parse(x[9]) - Int32.Parse(x[4])).ToString();



        }

        private void Update_stock_Click(object sender, EventArgs e)
        {
            Stock_calc();

        }

        double Bier1, Bier2, Fris1, Fris2, AA1, AA2, Wijn1, Wijn2, Snoep1, Snoep2;

        private void Update_Nieuwe_Periode_Click(object sender, EventArgs e)
        {
            //dB.Update_oldCount(Int32.Parse(Bier_count_update.Text), Int32.Parse(Fris_count_update.Text), Int32.Parse(Wijn_count_update.Text), Int32.Parse(Snoep_count_update.Text), Int32.Parse(AA_count_update.Text));
        }

        private void Stock_calc()
        {
            New_Bier_Count.Text = Bier_count_update.Text;
            New_Wijn_Count.Text = Wijn_count_update.Text;
            New_Snoep_Count.Text = Snoep_count_update.Text;
            New_Fris_Count.Text = Fris_count_update.Text;
            New_AA_Count.Text = AA_count_update.Text;

            Bier1 = Int32.Parse(Old_Bier_Count.Text) - Int32.Parse(New_Bier_Count.Text);
            Bier2 = Int32.Parse(Bier_sold.Text);
            double x = (((Bier2)/Bier1)*100);
            Fris1 = Int32.Parse(Old_Fris_Count.Text) - Int32.Parse(New_Fris_Count.Text);
            Fris2 = Int32.Parse(Fris_sold.Text);
            double y = (((Fris2) / Fris1) * 100);
            AA1 = Int32.Parse(Old_AA_Count.Text) - Int32.Parse(New_AA_Count.Text);
            AA2 = Int32.Parse(AA_sold.Text);
            double b = (((AA2) / AA1) * 100);
            Wijn1 = Int32.Parse(Old_Wijn_Count.Text) - Int32.Parse(New_Wijn_Count.Text);
            Wijn2 = Int32.Parse(Wijn_sold.Text);
            double c = (((Wijn2) / Wijn1) * 100);
            Snoep1 = Int32.Parse(Old_Snoep_Count.Text) - Int32.Parse(New_Snoep_Count.Text);
            Snoep2 = Int32.Parse(Snoep_sold.Text);
            double g = (((Snoep2) / Snoep1) * 100);

            Differens_bier.Text = x.ToString();
            Differens_Fris.Text = y.ToString();
            Differens_AA.Text = b.ToString();
            Differens_Wijn.Text = c.ToString();
            Differens_Snoep.Text = g.ToString();
        }
    }
}
