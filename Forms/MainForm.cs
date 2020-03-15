using JewelryStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelryStore.Forms
{
    /// <summary>
    /// главная форма
    /// </summary>
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            RefreshGrid();
            Login();
        }
        /// <summary>
        /// авторизация 
        /// </summary>
        public void Login()
        {
            Hide();
            if (new LoginForm().ShowDialog() == DialogResult.OK)
                Show();
            else
                Close();
        }
        /// <summary>
        /// обновление таблицы
        /// </summary>
        public void RefreshGrid()
        {
            SalesGrid.Rows.Clear();
            var context = new ApplicationDbContext();
            //TODO получение всех продаж с материалами
            foreach (var m in context.Sales.Include(x=>x.Production.MaterialCosts.Select(u=>u.Material)).ToList())
            {
                SalesGrid.Rows.Add(m.Id, m.BuyerFullName, m.SaleDate, m.Production.Name,m.Total);
            }
        }
        /// <summary>
        /// контестное меню таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SalesMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                int currentMouseOverRow = SalesGrid.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Просмотр", new EventHandler(delegate (Object o, EventArgs a)
                    {
                        int id = (int)SalesGrid.Rows[currentMouseOverRow].Cells[0].Value;
                        var form = new SaleForm(id, Models.EditMode.View);
                        form.ShowDialog();
                        RefreshGrid();
                    })));
                    m.MenuItems.Add(new MenuItem("Редактировать", new EventHandler(delegate (Object o, EventArgs a)
                    {
                        int id = (int)SalesGrid.Rows[currentMouseOverRow].Cells[0].Value;
                        var form = new SaleForm(id, Models.EditMode.Edit);
                        form.ShowDialog();
                        RefreshGrid();
                    })));
                    m.MenuItems.Add(new MenuItem("Удалить", new EventHandler(delegate (Object o, EventArgs a)
                    {
                        int id = (int)SalesGrid.Rows[currentMouseOverRow].Cells[0].Value;
                        if (MessageBox.Show("Вы точно хотите удалить этот элемент?", "Удалить?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            var context = new ApplicationDbContext();
                            //TODO удаление продажи по ключу
                            context.Sales.Remove(context.Sales.FirstOrDefault(x => x.Id == id));
                            context.SaveChanges();
                        }
                        RefreshGrid();
                    })));
                }

                m.Show(SalesGrid, new Point(e.X, e.Y));

            }
        }
        /// <summary>
        /// вызов формы для добавления материала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMaterial_Click(object sender, EventArgs e)
        {
            var form = new MaterialForm();
            form.ShowDialog();
            RefreshGrid();
        }
        /// <summary>
        /// вызов формы для добавления продукции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProduction_Click(object sender, EventArgs e)
        {
            var form = new ProductionForm();
            form.ShowDialog();
            RefreshGrid();
            RefreshGrid();
        }
        /// <summary>
        /// вызов формы для просмотра материалов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewMaterial_Click(object sender, EventArgs e)
        {
            var form = new MaterialsForm();
            form.ShowDialog();
            RefreshGrid();
        }
        /// <summary>
        /// вызов формы для просмотра изделий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewProduction_Click(object sender, EventArgs e)
        {
            var form = new ProductionsForm();
            form.ShowDialog();
            RefreshGrid();
        }
        /// <summary>
        /// вызов формы для добавления продажи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSale_Click(object sender, EventArgs e)
        {
            var form = new SaleForm();
            form.ShowDialog();
            RefreshGrid();
        }
        /// <summary>
        /// вызов формы для поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Click(object sender, EventArgs e)
        {
            var form = new BuyersSearchForm();
            form.ShowDialog();
            RefreshGrid();
        }

        private void Regular(object sender, EventArgs e)
        {
            var form = new BuyersData();
            form.ShowDialog();
            RefreshGrid();
        }

        private void поискПоТипуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new TypeSearch();
            form.ShowDialog();
            RefreshGrid();
        }
    }
}
