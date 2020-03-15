namespace JewelryStore.Forms
{
    partial class SaleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.BuyerFullName = new System.Windows.Forms.TextBox();
            this.mainBtn = new System.Windows.Forms.Button();
            this.SaleDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Production = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.NumericUpDown();
            this.Cost = new System.Windows.Forms.NumericUpDown();
            this.Total = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Discount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ф.И.О. покупателя";
            // 
            // BuyerFullName
            // 
            this.BuyerFullName.Location = new System.Drawing.Point(122, 6);
            this.BuyerFullName.Name = "BuyerFullName";
            this.BuyerFullName.Size = new System.Drawing.Size(263, 20);
            this.BuyerFullName.TabIndex = 1;
            this.BuyerFullName.TextChanged += new System.EventHandler(this.BuyerFullName_TextChanged);
            // 
            // mainBtn
            // 
            this.mainBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mainBtn.Location = new System.Drawing.Point(310, 79);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(75, 23);
            this.mainBtn.TabIndex = 4;
            this.mainBtn.Text = "Btn";
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // SaleDate
            // 
            this.SaleDate.Location = new System.Drawing.Point(95, 32);
            this.SaleDate.Name = "SaleDate";
            this.SaleDate.Size = new System.Drawing.Size(120, 20);
            this.SaleDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Дата покупки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Скидка";
            // 
            // Production
            // 
            this.Production.FormattingEnabled = true;
            this.Production.Location = new System.Drawing.Point(278, 30);
            this.Production.Name = "Production";
            this.Production.Size = new System.Drawing.Size(107, 21);
            this.Production.TabIndex = 9;
            this.Production.SelectedValueChanged += new System.EventHandler(this.Production_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Изделие";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Цена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Итого";
            // 
            // Discount
            // 
            this.Discount.DecimalPlaces = 2;
            this.Discount.Enabled = false;
            this.Discount.Location = new System.Drawing.Point(188, 56);
            this.Discount.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Size = new System.Drawing.Size(84, 20);
            this.Discount.TabIndex = 14;
            // 
            // Cost
            // 
            this.Cost.DecimalPlaces = 2;
            this.Cost.Enabled = false;
            this.Cost.Location = new System.Drawing.Point(52, 58);
            this.Cost.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            this.Cost.Size = new System.Drawing.Size(80, 20);
            this.Cost.TabIndex = 15;
            // 
            // Total
            // 
            this.Total.DecimalPlaces = 2;
            this.Total.Enabled = false;
            this.Total.Location = new System.Drawing.Point(52, 87);
            this.Total.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(77, 20);
            this.Total.TabIndex = 16;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 111);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Production);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaleDate);
            this.Controls.Add(this.mainBtn);
            this.Controls.Add(this.BuyerFullName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SaleForm";
            this.Text = "Продажа";
            ((System.ComponentModel.ISupportInitialize)(this.Discount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Total)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BuyerFullName;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.DateTimePicker SaleDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Production;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Discount;
        private System.Windows.Forms.NumericUpDown Cost;
        private System.Windows.Forms.NumericUpDown Total;
    }
}