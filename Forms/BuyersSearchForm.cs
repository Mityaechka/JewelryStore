using JewelryStore.Data;
using JewelryStore.Models;
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
    /// форма поиска по имение
    /// </summary>
    public partial class BuyersSearchForm : Form
    {
        public BuyersSearchForm()
        {
            InitializeComponent();
            RefreshGrid();
            StartDate.CustomFormat = "HH:mm dd.MM.yyyy";
        }
        /// <summary>
        /// обновление таблицы
        /// </summary>
        public void RefreshGrid()
        {
            SalesGrid.Rows.Clear();
            var context = new ApplicationDbContext();
            //TODO получение всех продаж с с включением продукции из 2-ой таблицы
            foreach (var m in context.Sales.Include(x=>x.Production.MaterialCosts.Select(u=>u.Material)).ToList())
            {
                SalesGrid.Rows.Add(m.Id, m.BuyerFullName, m.SaleDate, m.Production.Name,m.Total);
            }
        }
        /// <summary>
        /// обновление таблицы с помощью массива
        /// </summary>
        /// <param name="sales"></param>
        public void RefreshGrid(Sale[] sales)
        {
            SalesGrid.Rows.Clear();
            foreach (var m in sales)
            {
                SalesGrid.Rows.Add(m.Id, m.BuyerFullName, m.SaleDate, m.Production.Name, m.Total);
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
        /// поиск покупателей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var context = new ApplicationDbContext();
            var d = StartDate.Value;
            //TODO выборка из таблицы продажи в включение материалов и фильтрацией по дате
            var s = context.Sales.Include(x => x.Production.MaterialCosts.Select(u => u.Material)).Where(x => x.SaleDate >= d);
            if (!string.IsNullOrEmpty(Search.Text))
            {
                var str = Search.Text;
                //TODO выборка продаж по имени
                s = s.Where(x => x.BuyerFullName.Contains(str));
            }
            RefreshGrid(s.ToArray());
        }
        /// <summary>
        /// очистка таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
