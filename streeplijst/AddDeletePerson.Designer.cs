namespace streeplijst
{
    partial class AddDeletePerson
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
            this.label2 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.firstName = new System.Windows.Forms.TextBox();
            this.Names = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.Terug = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.Team = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(294, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 39);
            this.label2.TabIndex = 12;
            this.label2.Text = "lastname";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lastName.Location = new System.Drawing.Point(301, 100);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(199, 45);
            this.lastName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(38, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "firstname";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Add.Location = new System.Drawing.Point(666, 49);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(225, 96);
            this.Add.TabIndex = 9;
            this.Add.Text = "toevoegen";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // firstName
            // 
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.firstName.Location = new System.Drawing.Point(45, 100);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(199, 45);
            this.firstName.TabIndex = 8;
            // 
            // Names
            // 
            this.Names.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Names.FormattingEnabled = true;
            this.Names.ItemHeight = 38;
            this.Names.Location = new System.Drawing.Point(43, 459);
            this.Names.Name = "Names";
            this.Names.Size = new System.Drawing.Size(512, 194);
            this.Names.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBox1.Location = new System.Drawing.Point(43, 393);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(512, 45);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Delete.Location = new System.Drawing.Point(607, 393);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(210, 89);
            this.Delete.TabIndex = 15;
            this.Delete.Text = "verwijderen";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Terug
            // 
            this.Terug.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Terug.Location = new System.Drawing.Point(804, 573);
            this.Terug.Name = "Terug";
            this.Terug.Size = new System.Drawing.Size(182, 116);
            this.Terug.TabIndex = 16;
            this.Terug.Text = "Terug";
            this.Terug.UseVisualStyleBackColor = true;
            this.Terug.Click += new System.EventHandler(this.Terug_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label.Location = new System.Drawing.Point(522, 49);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(104, 39);
            this.label.TabIndex = 18;
            this.label.Text = "Team";
            // 
            // Team
            // 
            this.Team.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Team.Location = new System.Drawing.Point(529, 100);
            this.Team.Name = "Team";
            this.Team.Size = new System.Drawing.Size(97, 45);
            this.Team.TabIndex = 17;
            // 
            // AddDeletePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 729);
            this.Controls.Add(this.label);
            this.Controls.Add(this.Team);
            this.Controls.Add(this.Terug);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Names);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.firstName);
            this.Name = "AddDeletePerson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.ListBox Names;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Terug;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox Team;
    }
}