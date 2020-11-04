namespace streeplijst
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.bierlijst = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bier_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bier_teams = new System.Windows.Forms.ListView();
            this.Team = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maandelijks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // bierlijst
            // 
            this.bierlijst.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.LastName,
            this.Bier_Count,
            this.number});
            this.bierlijst.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.bierlijst.GridLines = true;
            this.bierlijst.HideSelection = false;
            this.bierlijst.Location = new System.Drawing.Point(23, 60);
            this.bierlijst.Name = "bierlijst";
            this.bierlijst.Scrollable = false;
            this.bierlijst.Size = new System.Drawing.Size(343, 649);
            this.bierlijst.TabIndex = 4;
            this.bierlijst.UseCompatibleStateImageBehavior = false;
            this.bierlijst.View = System.Windows.Forms.View.Details;
            this.bierlijst.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            this.bierlijst.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            // 
            // FirstName
            // 
            this.FirstName.DisplayIndex = 1;
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 105;
            // 
            // LastName
            // 
            this.LastName.DisplayIndex = 2;
            this.LastName.Text = "Last Name";
            this.LastName.Width = 105;
            // 
            // Bier_Count
            // 
            this.Bier_Count.DisplayIndex = 3;
            this.Bier_Count.Text = "Bier";
            this.Bier_Count.Width = 50;
            // 
            // number
            // 
            this.number.DisplayIndex = 0;
            this.number.Text = "number";
            this.number.Width = 70;
            // 
            // bier_teams
            // 
            this.bier_teams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Team,
            this.Bier});
            this.bier_teams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bier_teams.HideSelection = false;
            this.bier_teams.Location = new System.Drawing.Point(397, 60);
            this.bier_teams.Name = "bier_teams";
            this.bier_teams.Size = new System.Drawing.Size(179, 293);
            this.bier_teams.TabIndex = 1;
            this.bier_teams.Tag = "bier";
            this.bier_teams.UseCompatibleStateImageBehavior = false;
            this.bier_teams.View = System.Windows.Forms.View.Details;
            this.bier_teams.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            this.bier_teams.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            // 
            // Team
            // 
            this.Team.Text = "Team";
            this.Team.Width = 110;
            // 
            // Bier
            // 
            this.Bier.Text = "Bier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jupiler League";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(400, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teams";
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(600, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "Maandelijkse Jupiler League";
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            // 
            // maandelijks
            // 
            this.maandelijks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.maandelijks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maandelijks.HideSelection = false;
            this.maandelijks.Location = new System.Drawing.Point(606, 60);
            this.maandelijks.Name = "maandelijks";
            this.maandelijks.Size = new System.Drawing.Size(406, 649);
            this.maandelijks.TabIndex = 7;
            this.maandelijks.UseCompatibleStateImageBehavior = false;
            this.maandelijks.View = System.Windows.Forms.View.Details;
            this.maandelijks.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            this.maandelijks.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "number";
            this.columnHeader1.Text = "Number";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "First Name";
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Tag = "Last Name";
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "Bier";
            this.columnHeader4.Text = "Bier";
            this.columnHeader4.Width = 57;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(33)))), ((int)(((byte)(147)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1024, 729);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maandelijks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bier_teams);
            this.Controls.Add(this.bierlijst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StartForm_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView bierlijst;
        private System.Windows.Forms.ListView bier_teams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Bier_Count;
        private System.Windows.Forms.ColumnHeader Team;
        private System.Windows.Forms.ColumnHeader Bier;
        private System.Windows.Forms.ColumnHeader number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView maandelijks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}