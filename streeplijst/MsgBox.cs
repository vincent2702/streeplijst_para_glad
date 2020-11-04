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
    public partial class MsgBox : Form
    {
        // Font and Brush for the text graphics
        int FontSizeDefault = 12;
        Font DefaultFont;


        public MsgBox()
        {
            InitializeComponent();
            
            this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            DefaultFont = new Font("Tahoma", FontSizeDefault, FontStyle.Regular);
        }

        static MsgBox _MsgBox; static DialogResult result = DialogResult.No;
        public static DialogResult Show(string text, string Caption, string yes, string no)
        {
            _MsgBox = new MsgBox();
            float font_size = GetFontSize(_MsgBox.message, text, 10, 1, 1000);
            _MsgBox.message.Font = new Font(_MsgBox.message.Font.FontFamily, font_size);
            _MsgBox.message.Text = text;
            _MsgBox.Ja.Text = yes;
            _MsgBox.Nee.Text = no;
            _MsgBox.Text = Caption;
            _MsgBox.ShowDialog();
            return result;
        }

        private void Ja_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; _MsgBox.Close();
        }

        private void Nee_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; _MsgBox.Close();
        }

        // Return the largest font size that lets the text fit.
        static private float GetFontSize(TextBox textBox, string text,
            int margin, float min_size, float max_size)
        {
            // Only bother if there's text.
            if (text.Length == 0) return min_size;

            // See how much room we have, allowing a bit
            // for the Label's internal margin.
            int wid = textBox.DisplayRectangle.Width - margin;
            int hgt = textBox.DisplayRectangle.Height - margin;

            // Make a Graphics object to measure the text.
            using (Graphics gr = textBox.CreateGraphics())
            {
                while (max_size - min_size > 0.1f)
                {
                    float pt = (min_size + max_size) / 2f;
                    using (Font test_font =
                        new Font(textBox.Font.FontFamily, pt))
                    {
                        // See if this font is too big.
                        SizeF text_size =
                            gr.MeasureString(text, test_font);
                        if ((text_size.Width > wid) ||
                            (text_size.Height > hgt))
                            max_size = pt;
                        else
                            min_size = pt;
                    }
                }
                return min_size;
            }
        }
    }
    
}
