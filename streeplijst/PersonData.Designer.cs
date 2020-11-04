namespace streeplijst
{
    partial class PersonData
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
            this.SerachBox = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Update_lijst = new System.Windows.Forms.Button();
            this.Names = new System.Windows.Forms.ListBox();
            this.Data_person = new System.Windows.Forms.ListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // SerachBox
            // 
            this.SerachBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.SerachBox.Location = new System.Drawing.Point(12, 63);
            this.SerachBox.Name = "SerachBox";
            this.SerachBox.Size = new System.Drawing.Size(418, 45);
            this.SerachBox.TabIndex = 0;
            this.SerachBox.TextChanged += new System.EventHandler(this.SerachBox_TextChanged);
            // 
            // FullName
            // 
            this.FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.FullName.Location = new System.Drawing.Point(488, 63);
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Size = new System.Drawing.Size(406, 45);
            this.FullName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(483, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "First and Last Name";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ID.Location = new System.Drawing.Point(900, 63);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(100, 45);
            this.ID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(895, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID Number";
            // 
            // Update_lijst
            // 
            this.Update_lijst.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Update_lijst.Location = new System.Drawing.Point(639, 481);
            this.Update_lijst.Name = "Update_lijst";
            this.Update_lijst.Size = new System.Drawing.Size(156, 98);
            this.Update_lijst.TabIndex = 21;
            this.Update_lijst.Text = "Update";
            this.Update_lijst.UseVisualStyleBackColor = true;
            this.Update_lijst.Click += new System.EventHandler(this.Update_Click);
            // 
            // Names
            // 
            this.Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Names.FormattingEnabled = true;
            this.Names.ItemHeight = 38;
            this.Names.Location = new System.Drawing.Point(12, 136);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(418, 498);
            this.Names.TabIndex = 22;
            this.Names.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Names_MouseClick);
            // 
            // Data_person
            // 
            this.Data_person.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Data_person.FormattingEnabled = true;
            this.Data_person.ItemHeight = 38;
            this.Data_person.Location = new System.Drawing.Point(488, 136);
            this.Data_person.Name = "Data_person";
            this.Data_person.Size = new System.Drawing.Size(286, 308);
            this.Data_person.TabIndex = 23;
            this.Data_person.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Data_person_MouseClick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.numericUpDown1.Location = new System.Drawing.Point(488, 505);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 45);
            this.numericUpDown1.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(481, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 39);
            this.label3.TabIndex = 25;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.button1.Location = new System.Drawing.Point(826, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 129);
            this.button1.TabIndex = 26;
            this.button1.Text = "Terug";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Data_person);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.Update_lijst);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FullName);
            this.Controls.Add(this.SerachBox);
            this.Name = "PersonData";
            this.Text = "PersonData";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SerachBox;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Update_lijst;
        private System.Windows.Forms.ListBox Names;
        private System.Windows.Forms.ListBox Data_person;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}