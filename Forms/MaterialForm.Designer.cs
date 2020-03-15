namespace JewelryStore.Forms
{
    partial class MaterialForm
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
            this.NameT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GramCost = new System.Windows.Forms.NumericUpDown();
            this.mainBtn = new System.Windows.Forms.Button();
            this.Consists = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GramCost)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // NameT
            // 
            this.NameT.Location = new System.Drawing.Point(90, 9);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(120, 20);
            this.NameT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Цена(грамм)";
            // 
            // GramCost
            // 
            this.GramCost.DecimalPlaces = 2;
            this.GramCost.Location = new System.Drawing.Point(90, 40);
            this.GramCost.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.GramCost.Name = "GramCost";
            this.GramCost.Size = new System.Drawing.Size(120, 20);
            this.GramCost.TabIndex = 3;
            // 
            // mainBtn
            // 
            this.mainBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mainBtn.Location = new System.Drawing.Point(134, 64);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(75, 23);
            this.mainBtn.TabIndex = 4;
            this.mainBtn.Text = "Btn";
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // Consists
            // 
            this.Consists.Location = new System.Drawing.Point(15, 64);
            this.Consists.Name = "Consists";
            this.Consists.Size = new System.Drawing.Size(75, 23);
            this.Consists.TabIndex = 5;
            this.Consists.Text = "Изделия";
            this.Consists.UseVisualStyleBackColor = true;
            this.Consists.Visible = false;
            this.Consists.Click += new System.EventHandler(this.Consists_Click);
            // 
            // MaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 99);
            this.Controls.Add(this.Consists);
            this.Controls.Add(this.mainBtn);
            this.Controls.Add(this.GramCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MaterialForm";
            this.Text = "Материал";
            ((System.ComponentModel.ISupportInitialize)(this.GramCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown GramCost;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.Button Consists;
    }
}