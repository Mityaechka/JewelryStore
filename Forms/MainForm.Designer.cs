namespace JewelryStore.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SalesGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.AddSale = new System.Windows.Forms.ToolStripMenuItem();
            this.Search = new System.Windows.Forms.ToolStripMenuItem();
            this.постоянныеПокупателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ViewProduction = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProduction = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ViewMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMaterial = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоТипуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesGrid
            // 
            this.SalesGrid.AllowUserToAddRows = false;
            this.SalesGrid.AllowUserToDeleteRows = false;
            this.SalesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.Column4,
            this.Column5});
            this.SalesGrid.Location = new System.Drawing.Point(12, 31);
            this.SalesGrid.Name = "SalesGrid";
            this.SalesGrid.ReadOnly = true;
            this.SalesGrid.Size = new System.Drawing.Size(563, 166);
            this.SalesGrid.TabIndex = 0;
            this.SalesGrid.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SalesMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
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
            this.Column2.HeaderText = "Дата продажи";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Изделие";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Итого";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Совершенные продажи";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(587, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSale,
            this.Search,
            this.постоянныеПокупателиToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(71, 22);
            this.toolStripDropDownButton1.Text = "Продажи";
            // 
            // AddSale
            // 
            this.AddSale.Name = "AddSale";
            this.AddSale.Size = new System.Drawing.Size(230, 22);
            this.AddSale.Text = "Добавить";
            this.AddSale.Click += new System.EventHandler(this.AddSale_Click);
            // 
            // Search
            // 
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(230, 22);
            this.Search.Text = "Поиск";
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // постоянныеПокупателиToolStripMenuItem
            // 
            this.постоянныеПокупателиToolStripMenuItem.Name = "постоянныеПокупателиToolStripMenuItem";
            this.постоянныеПокупателиToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.постоянныеПокупателиToolStripMenuItem.Text = "Информация о покупателях";
            this.постоянныеПокупателиToolStripMenuItem.Click += new System.EventHandler(this.Regular);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewProduction,
            this.AddProduction,
            this.поискПоТипуToolStripMenuItem});
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(81, 22);
            this.toolStripDropDownButton3.Text = "Продукция";
            // 
            // ViewProduction
            // 
            this.ViewProduction.Name = "ViewProduction";
            this.ViewProduction.Size = new System.Drawing.Size(180, 22);
            this.ViewProduction.Text = "Просмотр";
            this.ViewProduction.Click += new System.EventHandler(this.ViewProduction_Click);
            // 
            // AddProduction
            // 
            this.AddProduction.Name = "AddProduction";
            this.AddProduction.Size = new System.Drawing.Size(180, 22);
            this.AddProduction.Text = "Добавить";
            this.AddProduction.Click += new System.EventHandler(this.AddProduction_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewMaterial,
            this.AddMaterial});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(84, 22);
            this.toolStripDropDownButton2.Text = "Материалы";
            // 
            // ViewMaterial
            // 
            this.ViewMaterial.Name = "ViewMaterial";
            this.ViewMaterial.Size = new System.Drawing.Size(180, 22);
            this.ViewMaterial.Text = "Просмотр";
            this.ViewMaterial.Click += new System.EventHandler(this.ViewMaterial_Click);
            // 
            // AddMaterial
            // 
            this.AddMaterial.Name = "AddMaterial";
            this.AddMaterial.Size = new System.Drawing.Size(180, 22);
            this.AddMaterial.Text = "Добавить";
            this.AddMaterial.Click += new System.EventHandler(this.AddMaterial_Click);
            // 
            // поискПоТипуToolStripMenuItem
            // 
            this.поискПоТипуToolStripMenuItem.Name = "поискПоТипуToolStripMenuItem";
            this.поискПоТипуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поискПоТипуToolStripMenuItem.Text = "Поиск по типу";
            this.поискПоТипуToolStripMenuItem.Click += new System.EventHandler(this.поискПоТипуToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 209);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SalesGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Главная страница";
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem AddSale;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripMenuItem ViewProduction;
        private System.Windows.Forms.ToolStripMenuItem AddProduction;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem ViewMaterial;
        private System.Windows.Forms.ToolStripMenuItem AddMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem Search;
        private System.Windows.Forms.ToolStripMenuItem постоянныеПокупателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоТипуToolStripMenuItem;
    }
}