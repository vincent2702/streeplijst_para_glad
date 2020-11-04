namespace streeplijst
{
    partial class OrderForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.Klaar = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.number = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item05 = new System.Windows.Forms.Button();
            this.Item5 = new System.Windows.Forms.Button();
            this.Item04 = new System.Windows.Forms.Button();
            this.Item4 = new System.Windows.Forms.Button();
            this.Item3 = new System.Windows.Forms.Button();
            this.Item02 = new System.Windows.Forms.Button();
            this.Item03 = new System.Windows.Forms.Button();
            this.Item2 = new System.Windows.Forms.Button();
            this.Item01 = new System.Windows.Forms.Button();
            this.Item1 = new System.Windows.Forms.Button();
            this.Item6 = new System.Windows.Forms.Button();
            this.Item06 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Klaar
            // 
            this.Klaar.BackColor = System.Drawing.Color.Red;
            this.Klaar.FlatAppearance.BorderSize = 0;
            this.Klaar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Klaar.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Klaar.Location = new System.Drawing.Point(824, 99);
            this.Klaar.Name = "Klaar";
            this.Klaar.Size = new System.Drawing.Size(172, 284);
            this.Klaar.TabIndex = 0;
            this.Klaar.Text = "Klaar";
            this.Klaar.UseVisualStyleBackColor = false;
            this.Klaar.Click += new System.EventHandler(this.Klaar_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(49)))), ((int)(((byte)(143)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.name.ForeColor = System.Drawing.SystemColors.Control;
            this.name.Location = new System.Drawing.Point(271, 22);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(512, 46);
            this.name.TabIndex = 2;
            this.name.Text = "name";
            // 
            // timer1
            // 
            this.timer1.Interval = 50000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // number
            // 
            this.number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(49)))), ((int)(((byte)(143)))));
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.number.ForeColor = System.Drawing.SystemColors.Control;
            this.number.Location = new System.Drawing.Point(824, 22);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(210, 46);
            this.number.TabIndex = 7;
            this.number.Text = "plaats 25";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.LightGray;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 99);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(245, 297);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 167;
            // 
            // Item05
            // 
            this.Item05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(190)))), ((int)(((byte)(1)))));
            this.Item05.CausesValidation = false;
            this.Item05.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item05.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.Item05.Location = new System.Drawing.Point(763, 599);
            this.Item05.Name = "Item05";
            this.Item05.Size = new System.Drawing.Size(217, 82);
            this.Item05.TabIndex = 5;
            this.Item05.Text = "AA -";
            this.Item05.UseVisualStyleBackColor = false;
            this.Item05.Click += new System.EventHandler(this.Main_Click);
            // 
            // Item5
            // 
            this.Item5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(190)))), ((int)(((byte)(1)))));
            this.Item5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item5.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.Item5.Location = new System.Drawing.Point(763, 410);
            this.Item5.Name = "Item5";
            this.Item5.Size = new System.Drawing.Size(217, 183);
            this.Item5.TabIndex = 4;
            this.Item5.Text = "AA +";
            this.Item5.UseVisualStyleBackColor = false;
            this.Item5.Click += new System.EventHandler(this.Main_Click);
            // 
            // Item04
            // 
            this.Item04.BackColor = System.Drawing.Color.LightGray;
            this.Item04.CausesValidation = false;
            this.Item04.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item04.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Item04.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Item04.Location = new System.Drawing.Point(512, 599);
            this.Item04.Name = "Item04";
            this.Item04.Size = new System.Drawing.Size(217, 82);
            this.Item04.TabIndex = 1;
            this.Item04.Text = "Snoep -";
            this.Item04.UseVisualStyleBackColor = false;
            this.Item04.Click += new System.EventHandler(this.Main_Click);
            // 
            // Item4
            // 
            this.Item4.BackColor = System.Drawing.Color.LightGray;
            this.Item4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Item4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item4.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.Item4.Location = new System.Drawing.Point(512, 410);
            this.Item4.Name = "Item4";
            this.Item4.Size = new System.Drawing.Size(217, 183);
            this.Item4.TabIndex = 0;
            this.Item4.Text = "Snoep +";
            this.Item4.UseVisualStyleBackColor = false;
            this.Item4.Click += new System.EventHandler(this.Main_Click);
            // 
            // Item3
            // 
            this.Item3.BackColor = System.Drawing.Color.LightGray;
            this.Item3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item3.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.Item3.Location = new System.Drawing.Point(272, 410);
            this.Item3.Name = "Item3";
            this.Item3.Size = new System.Drawing.Size(217, 183);
            this.Item3.TabIndex = 0;
            this.Item3.Text = "Wijn +";
            this.Item3.UseVisualStyleBackColor = false;
            this.Item3.Click += new System.EventHandler(this.Main_Click);
            // 
            // Item02
            // 
            this.Item02.BackColor = System.Drawing.Color.LightGray;
            this.Item02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item02.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.Item02.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Item02.Location = new System.Drawing.Point(547, 301);
            this.Item02.Name = "Item02";
            this.Item02.Size = new System.Drawing.Size(236, 82);
            this.Item02.TabIndex = 1;
            this.Item02.Text = "Fris -";
            this.Item02.UseVisualStyleBackColor = false;
            this.Item02.Click += new System.EventHandler(this.Main_Click);
            // 
            // Item03
            // 
            this.Item03.BackColor = System.Drawing.Color.LightGray;
            this.Item03.CausesValidation = false;
            this.Item03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item03.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.Item03.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Item03.Location = new System.Drawing.Point(271, 599);
            this.Item03.Name = "Item03";
            this.Item03.Size = new System.Drawing.Size(218, 82);
            this.Item03.TabIndex = 1;
            this.Item03.Text = "Wijn -";
            this.Item03.UseVisualStyleBackColor = false;
            this.Item03.Click += new System.EventHandler(this.Main_Click);
            // 
            // Item2
            // 
            this.Item2.BackColor = System.Drawing.Color.LightGray;
            this.Item2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item2.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.Item2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Item2.Location = new System.Drawing.Point(547, 99);
            this.Item2.Name = "Item2";
            this.Item2.Size = new System.Drawing.Size(236, 183);
            this.Item2.TabIndex = 0;
            this.Item2.Text = "Fris +";
            this.Item2.UseVisualStyleBackColor = false;
            this.Item2.Click += new System.EventHandler(this.Main_Click);
            // 
            // Item01
            // 
            this.Item01.BackColor = System.Drawing.Color.LightGray;
            this.Item01.CausesValidation = false;
            this.Item01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item01.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.Item01.Location = new System.Drawing.Point(271, 301);
            this.Item01.Name = "Item01";
            this.Item01.Size = new System.Drawing.Size(244, 82);
            this.Item01.TabIndex = 1;
            this.Item01.Text = "Bier -";
            this.Item01.UseVisualStyleBackColor = false;
            this.Item01.Click += new System.EventHandler(this.Main_Click);
            // 
            // Item1
            // 
            this.Item1.BackColor = System.Drawing.Color.LightGray;
            this.Item1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Item1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(49)))), ((int)(((byte)(143)))));
            this.Item1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.Item1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Item1.Location = new System.Drawing.Point(271, 99);
            this.Item1.Name = "Item1";
            this.Item1.Size = new System.Drawing.Size(244, 183);
            this.Item1.TabIndex = 0;
            this.Item1.Text = "Bier +";
            this.Item1.UseVisualStyleBackColor = false;
            this.Item1.Click += new System.EventHandler(this.Main_Click);
            // 
            // Item6
            // 
            this.Item6.BackColor = System.Drawing.Color.LightGray;
            this.Item6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Item6.CausesValidation = false;
            this.Item6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Item6.FlatAppearance.BorderSize = 0;
            this.Item6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(49)))), ((int)(((byte)(143)))));
            this.Item6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item6.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.Item6.Location = new System.Drawing.Point(28, 410);
            this.Item6.Name = "Item6";
            this.Item6.Size = new System.Drawing.Size(217, 183);
            this.Item6.TabIndex = 9;
            this.Item6.Text = "Wijn +";
            this.Item6.UseVisualStyleBackColor = false;
            // 
            // Item06
            // 
            this.Item06.BackColor = System.Drawing.Color.LightGray;
            this.Item06.CausesValidation = false;
            this.Item06.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(49)))), ((int)(((byte)(143)))));
            this.Item06.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Item06.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F);
            this.Item06.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Item06.Location = new System.Drawing.Point(27, 599);
            this.Item06.Name = "Item06";
            this.Item06.Size = new System.Drawing.Size(218, 82);
            this.Item06.TabIndex = 10;
            this.Item06.Text = "Wijn -";
            this.Item06.UseVisualStyleBackColor = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(49)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(1024, 729);
            this.Controls.Add(this.Item6);
            this.Controls.Add(this.Item06);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.number);
            this.Controls.Add(this.Item05);
            this.Controls.Add(this.Item5);
            this.Controls.Add(this.Item04);
            this.Controls.Add(this.Item4);
            this.Controls.Add(this.Item3);
            this.Controls.Add(this.Item02);
            this.Controls.Add(this.Item03);
            this.Controls.Add(this.Item2);
            this.Controls.Add(this.Item01);
            this.Controls.Add(this.Item1);
            this.Controls.Add(this.Klaar);
            this.Controls.Add(this.name);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Streeplijst";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Klaar;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button Item1;
        private System.Windows.Forms.Button Item01;
        private System.Windows.Forms.Button Item2;
        private System.Windows.Forms.Button Item02;
        private System.Windows.Forms.Button Item3;
        private System.Windows.Forms.Button Item03;
        private System.Windows.Forms.Button Item4;
        internal System.Windows.Forms.Button Item04;
        private System.Windows.Forms.Button Item5;
        internal System.Windows.Forms.Button Item05;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button Item6;
        private System.Windows.Forms.Button Item06;
    }
}

