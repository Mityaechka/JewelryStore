namespace JewelryStore.Forms
{
    partial class BuyersData
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
            this.SalesGrid = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesGrid
            // 
            this.SalesGrid.AllowUserToAddRows = false;
            this.SalesGrid.AllowUserToDeleteRows = false;
            this.SalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2});
            this.SalesGrid.Location = new System.Drawing.Point(12, 12);
            this.SalesGrid.Name = "SalesGrid";
            this.SalesGrid.ReadOnly = true;
            this.SalesGrid.Size = new System.Drawing.Size(276, 166);
            this.SalesGrid.TabIndex = 0;
            this.SalesGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SalesMouseClick);
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Ф.И.О. покупателя";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Куплено изделий";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // RegularBuers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 188);
            this.Controls.Add(this.SalesGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegularBuers";
            this.Text = "Информация о покупках";
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}