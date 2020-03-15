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
    /// форма с информацией о покупателе 
    /// </summary>
    public partial class BuyerData : Form
    {
        string n;
        public BuyerData(string N)
        {
            InitializeComponent();
            n = N;
            Text = $"Покупки {n}";
            RefreshGrid();
        }
        /// <summary>
        /// обновление таблицы
        /// </summary>
        public void RefreshGrid()
        {
            SalesGrid.Rows.Clear();
            var context = new ApplicationDbContext();
            //TODO получение всех продаж с включением продукции из 2ой старинцы
            foreach (var m in context.Sales.Include(x=>x.Production.MaterialCosts.Select(u=>u.Material))
                .Where(x=>x.BuyerFullName==n).ToList())
            {
                SalesGrid.Rows.Add(m.Id,   m.Production.Name, m.SaleDate, m.Total);
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
    }
}
