namespace streeplijst
{
    partial class Prices
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
            this.NewPrice = new System.Windows.Forms.NumericUpDown();
            this.newItem = new System.Windows.Forms.TextBox();
            this.Update_price_list = new System.Windows.Forms.Button();
            this.Itemsbox = new System.Windows.Forms.ListBox();
            this.Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NewPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // NewPrice
            // 
            this.NewPrice.Cursor = System.Windows.Forms.Cursors.Default;
            this.NewPrice.DecimalPlaces = 2;
            this.NewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.NewPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NewPrice.Location = new System.Drawing.Point(225, 44);
            this.NewPrice.Name = "NewPrice";
            this.NewPrice.Size = new System.Drawing.Size(141, 53);
            this.NewPrice.TabIndex = 80;
            // 
            // newItem
            // 
            this.newItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.newItem.Location = new System.Drawing.Point(41, 44);
            this.newItem.Name = "newItem";
            this.newItem.Size = new System.Drawing.Size(141, 53);
            this.newItem.TabIndex = 79;
            // 
            // Update_price_list
            // 
            this.Update_price_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Update_price_list.Location = new System.Drawing.Point(403, 44);
            this.Update_price_list.Name = "Update_price_list";
            this.Update_price_list.Size = new System.Drawing.Size(125, 53);
            this.Update_price_list.TabIndex = 49;
            this.Update_price_list.Text = "Update";
            this.Update_price_list.UseVisualStyleBackColor = true;
            this.Update_price_list.Click += new System.EventHandler(this.Update_price_list_Click);
            // 
            // Itemsbox
            // 
            this.Itemsbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Itemsbox.FormattingEnabled = true;
            this.Itemsbox.ItemHeight = 46;
            this.Itemsbox.Location = new System.Drawing.Point(41, 118);
            this.Itemsbox.Name = "Itemsbox";
            this.Itemsbox.Size = new System.Drawing.Size(369, 510);
            this.Itemsbox.TabIndex = 81;
            this.Itemsbox.SelectedIndexChanged += new System.EventHandler(this.Itemsbox_SelectedIndexChanged);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Exit.Location = new System.Drawing.Point(771, 500);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(179, 128);
            this.Exit.TabIndex = 82;
            this.Exit.Text = "Terug";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Prices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 729);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Itemsbox);
            this.Controls.Add(this.NewPrice);
            this.Controls.Add(this.newItem);
            this.Controls.Add(this.Update_price_list);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "Prices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "prices";
            ((System.ComponentModel.ISupportInitialize)(this.NewPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NewPrice;
        private System.Windows.Forms.TextBox newItem;
        private System.Windows.Forms.Button Update_price_list;
        private System.Windows.Forms.ListBox Itemsbox;
        private System.Windows.Forms.Button Exit;
    }
}