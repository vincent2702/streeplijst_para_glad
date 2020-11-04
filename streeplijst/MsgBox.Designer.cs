namespace streeplijst
{
    partial class MsgBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.message = new System.Windows.Forms.TextBox();
            this.Ja = new System.Windows.Forms.Button();
            this.Nee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(9)))), ((int)(((byte)(156)))));
            this.message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F);
            this.message.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.message.HideSelection = false;
            this.message.Location = new System.Drawing.Point(0, 23);
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Size = new System.Drawing.Size(493, 76);
            this.message.TabIndex = 3;
            this.message.Text = "Bier Pong?";
            this.message.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Ja
            // 
            this.Ja.Location = new System.Drawing.Point(76, 123);
            this.Ja.Name = "Ja";
            this.Ja.Size = new System.Drawing.Size(140, 75);
            this.Ja.TabIndex = 1;
            this.Ja.Text = "button1";
            this.Ja.UseVisualStyleBackColor = true;
            this.Ja.Click += new System.EventHandler(this.Ja_Click);
            // 
            // Nee
            // 
            this.Nee.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Nee.Location = new System.Drawing.Point(280, 123);
            this.Nee.Name = "Nee";
            this.Nee.Size = new System.Drawing.Size(140, 75);
            this.Nee.TabIndex = 2;
            this.Nee.Text = "button2";
            this.Nee.UseVisualStyleBackColor = true;
            this.Nee.Click += new System.EventHandler(this.Nee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 46);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(9)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.message);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(493, 117);
            this.panel1.TabIndex = 1;
            // 
            // MsgBox
            // 
            this.AcceptButton = this.Ja;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(9)))), ((int)(((byte)(156)))));
            this.CancelButton = this.Nee;
            this.ClientSize = new System.Drawing.Size(493, 237);
            this.Controls.Add(this.Nee);
            this.Controls.Add(this.Ja);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MsgBox";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgBox";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.Button Ja;
        private System.Windows.Forms.Button Nee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}