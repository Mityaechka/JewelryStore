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
    /// форма с информацией о покупках пользователей
    /// </summary>
    public partial class BuyersData : Form
    {
        public BuyersData()
        {
            InitializeComponent();

            RefreshGrid();
        }
        /// <summary>
        /// обновление таблицы
        /// </summary>
        public void RefreshGrid()
        {
            SalesGrid.Rows.Clear();
            var context = new ApplicationDbContext();
            //TODO получение всех продаж с с включением продукции из 2-ой таблицы
            foreach (var m in context.Sales.Include(x=>x.Production.MaterialCosts.Select(u=>u.Material))
                .GroupBy(x=>x.BuyerFullName).ToList())
            {

                SalesGrid.Rows.Add(m.Key, m.Count() );
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
                        string id = (string)SalesGrid.Rows[currentMouseOverRow].Cells[0].Value;
                        var form = new BuyerData(id);
                        form.ShowDialog();
                        RefreshGrid();
                    })));
                }

                m.Show(SalesGrid, new Point(e.X, e.Y));

            }
        }
    }
  
}
