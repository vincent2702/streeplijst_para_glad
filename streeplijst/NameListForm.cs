using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using streeplijst_library;


namespace streeplijst
{
    public partial class NameListForm : Form
    {
       
        BindingSource itemsBinding = new BindingSource();
        BindingSource ledenBinding = new BindingSource();

        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool PostMessage(IntPtr hWnd, uint Msg, UIntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindow(String sClassName, String sAppName);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, String lpszClass, String lpszWindow);


        public NameListForm()
        {
            InitializeComponent();
           // this.ShowInTaskbar = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ActiveControl = textBox1;

            Update_List();
            
        }


        public void Update_List()
        {
            timer1.Start();
            textBox1.Focus();
            this.ActiveControl = textBox1;
            ledenBinding.DataSource = FormList.OrderForm.dBConnect.Names.Leden;
            NameList.DataSource = null;
            NameList.DataSource = ledenBinding;

            NameList.DisplayMember = "Display";
            NameList.ValueMember = "Display";
        }


        /// <summary>
        /// Show the On Screen Keyboard
        /// </summary>
        #region ShowOSK
        public void ShowOnScreenKeyboard()
        {
            IntPtr parent = FindWindow("Shell_TrayWnd", null);
            IntPtr child1 = FindWindowEx(parent, IntPtr.Zero, "TrayNotifyWnd", "");
            IntPtr keyboardWnd = FindWindowEx(child1, IntPtr.Zero, null, "Touch keyboard");

            uint WM_LBUTTONDOWN = 0x0201;
            uint WM_LBUTTONUP = 0x0202;
            UIntPtr x = new UIntPtr(0x01);
            UIntPtr x1 = new UIntPtr(0);
            IntPtr y = new IntPtr(0x0240012);
            PostMessage(keyboardWnd, WM_LBUTTONDOWN, x, y);
            PostMessage(keyboardWnd, WM_LBUTTONUP, x1, y);
        }
        #endregion ShowOSK

        /// <summary>
        /// Hide the On Screen Keyboard
        /// </summary>
        #region HideOSK
        public void HideOnScreenKeyboard()
        {
            uint WM_SYSCOMMAND = 0x0112;
            UIntPtr SC_CLOSE = new UIntPtr(0xF060);
            IntPtr y = new IntPtr(0);
            IntPtr KeyboardWnd = FindWindow("IPTip_Main_Window", null);
            PostMessage(KeyboardWnd, WM_SYSCOMMAND, SC_CLOSE, y);
        }
        #endregion HideOSK


        private void NameList_MouseClick(object sender, MouseEventArgs e)
        {


            if (NameList.SelectedValue.ToString().ToLower() == "afsluiten\t")
            {if (MsgBox.Show("weet je het zeker", "", "JA", "NEE") == DialogResult.Yes) Application.Exit(); }
            else if (NameList.SelectedValue.ToString().ToLower() != "penning\tmeester")
            {
                HideOnScreenKeyboard();
                FormList.NameListForm.Hide();
                FormList.OrderForm.Show();
                FormList.OrderForm.FullName = (String)NameList.SelectedValue;
                FormList.OrderForm.GetData();
                FormList.OrderForm.timer1.Start();
                textBox1.Clear();
                timer1.Stop();
            }
            else
            {
                timer1.Stop();

                if (LogIn.Show("") == DialogResult.Yes)
                {

                    FormList.PenningMeesterForm.Show();
                    FormList.NameListForm.Hide();
                    FormList.OrderForm.Hide();
                    FormList.OrderForm.timer1.Stop();
                    HideOnScreenKeyboard();

                }
                else
                {
                    textBox1.Clear();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var x = textBox1.Text;
            FormList.OrderForm.dBConnect.Nameslist(x);
            Update_List();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormList.StartForm.Show();
            FormList.NameListForm.textBox1.Focus();
            FormList.NameListForm.Hide();
            timer1.Stop();
        }
        
        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            FormList.StartForm.Show();
            FormList.NameListForm.Hide();
            timer1.Stop();

        }
    }
}
