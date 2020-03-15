namespace JewelryStore.Forms
{
    partial class ProductionForm
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
            this.Weight = new System.Windows.Forms.NumericUpDown();
            this.mainBtn = new System.Windows.Forms.Button();
            this.Cost = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.materialGrid = new System.Windows.Forms.DataGridView();
            this.MaterialC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WeightC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialGrid)).BeginInit();
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
            this.NameT.Location = new System.Drawing.Point(75, 6);
            this.NameT.Name = "NameT";
            this.NameT.Size = new System.Drawing.Size(106, 20);
            this.NameT.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вес";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Weight
            // 
            this.Weight.DecimalPlaces = 2;
            this.Weight.Enabled = false;
            this.Weight.Location = new System.Drawing.Point(44, 148);
            this.Weight.Maximum = new decimal(new int[] {
            -1486618625,
            232830643,
            0,
            0});
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(106, 20);
            this.Weight.TabIndex = 3;
            this.Weight.ValueChanged += new System.EventHandler(this.Weight_ValueChanged);
            // 
            // mainBtn
            // 
            this.mainBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mainBtn.Location = new System.Drawing.Point(249, 176);
            this.mainBtn.Name = "mainBtn";
            this.mainBtn.Size = new System.Drawing.Size(75, 23);
            this.mainBtn.TabIndex = 4;
            this.mainBtn.Text = "Btn";
            this.mainBtn.UseVisualStyleBackColor = true;
            this.mainBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // Cost
            // 
            this.Cost.DecimalPlaces = 2;
            this.Cost.Enabled = false;
            this.Cost.Location = new System.Drawing.Point(204, 148);
            this.Cost.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.Cost.Name = "Cost";
            this.Cost.Size = new System.Drawing.Size(120, 20);
            this.Cost.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Материалы";
            // 
            // materialGrid
            // 
            this.materialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaterialC,
            this.WeightC});
            this.materialGrid.Location = new System.Drawing.Point(13, 45);
            this.materialGrid.Name = "materialGrid";
            this.materialGrid.Size = new System.Drawing.Size(314, 97);
            this.materialGrid.TabIndex = 9;
            this.materialGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.materialGrid_CellValueChanged);
            this.materialGrid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.materialGrid_RowsRemoved);
            // 
            // MaterialC
            // 
            this.MaterialC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaterialC.HeaderText = "Материал";
            this.MaterialC.Name = "MaterialC";
            this.MaterialC.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaterialC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // WeightC
            // 
            this.WeightC.HeaderText = "Вес";
            this.WeightC.Name = "WeightC";
            // 
            // Type
            // 
            this.Type.Location = new System.Drawing.Point(221, 6);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(106, 20);
            this.Type.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Тип";
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 208);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Cost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mainBtn);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductionForm";
            this.Text = "Продукция";
            ((System.ComponentModel.ISupportInitialize)(this.Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Weight;
        private System.Windows.Forms.Button mainBtn;
        private System.Windows.Forms.NumericUpDown Cost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView materialGrid;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaterialC;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightC;
        private System.Windows.Forms.TextBox Type;
        private System.Windows.Forms.Label label5;
    }
}