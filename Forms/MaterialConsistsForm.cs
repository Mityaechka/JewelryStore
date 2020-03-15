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
    /// форма изделий по материалам
    /// </summary>
    public partial class MaterialConsistsForm : Form
    {
        int Id;
        public MaterialConsistsForm(int id)
        {
            InitializeComponent();
            Id = id;
            RefreshGrid();
        }
        /// <summary>
        /// обновление таблицы
        /// </summary>
        public void RefreshGrid()
        {
            Grid.Rows.Clear();
            var context = new ApplicationDbContext();
            //TODO получение материала по ключу
            var mat = context.Materials.FirstOrDefault(x => x.Id == Id);
            Text = $"Изделия из {mat.Name}";
            //TODO получение продукции с включением материалов
            foreach (var m in context.Productions.Include(x=>x.MaterialCosts.Select(u=>u.Material))
                .Where(x=>x.MaterialCosts.Any(u=>u.MaterialId==Id)).ToList())
            {
                Grid.Rows.Add(m.Id, m.Name, m.Type,m.Weight,m.Cost);
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
                int currentMouseOverRow = Grid.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    m.MenuItems.Add(new MenuItem("Просмотр", new EventHandler(delegate (Object o, EventArgs a)
                    {
                        int id = (int)Grid.Rows[currentMouseOverRow].Cells[0].Value;
                        var form = new ProductionForm(id,Models.EditMode.View);
                        form.ShowDialog();
                        RefreshGrid();
                    })));
                    m.MenuItems.Add(new MenuItem("Редактировать", new EventHandler(delegate (Object o, EventArgs a)
                    {
                        int id = (int)Grid.Rows[currentMouseOverRow].Cells[0].Value;
                        var form = new ProductionForm(id, Models.EditMode.Edit);
                        form.ShowDialog();
                        RefreshGrid();
                    })));
                    m.MenuItems.Add(new MenuItem("Удалить", new EventHandler(delegate (Object o, EventArgs a)
                    {
                        int id = (int)Grid.Rows[currentMouseOverRow].Cells[0].Value;
                        if (MessageBox.Show("Вы точно хотите удалить этот элемент?", "Удалить?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            try
                            {
                                var context = new ApplicationDbContext();
                                //TODO удаление продукции
                                context.Productions.Remove(context.Productions.FirstOrDefault(x => x.Id == id));
                                context.SaveChanges();
                            }catch(Exception ex)
                            {
                                MessageBox.Show("Сначала необходимо удалить все связанные данные", "Ошибка");
                            }
                        }
                        RefreshGrid();
                    })));
                }

                m.Show(Grid, new Point(e.X, e.Y));

            }
        }
        /// <summary>
        /// вызов формы для добаления изделия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProduction_Click(object sender, EventArgs e)
        {
            var form = new ProductionForm();
            form.ShowDialog();
            RefreshGrid();
        }
    }
}
