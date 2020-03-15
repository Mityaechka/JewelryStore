using JewelryStore.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JewelryStore.Forms
{
    /// <summary>
    /// Форма метериалов
    /// </summary>
    public partial class MaterialsForm : Form
    {
        public MaterialsForm()
        {
            InitializeComponent();
            RefreshGrid();
        }
        /// <summary>
        /// обновление таблицы
        /// </summary>
        public void RefreshGrid()
        {
            Grid.Rows.Clear();
            var context = new ApplicationDbContext();
            //TODO получение всех материалов и запись их в таблицу
            foreach (var m in context.Materials.ToList())
            {
                Grid.Rows.Add(m.Id, m.Name, m.GramCost);
            }
        }
        /// <summary>
        /// контестное меню для таблицы
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
                        var form = new MaterialForm(id,Models.EditMode.View);
                        form.ShowDialog();
                        RefreshGrid();
                    })));
                    m.MenuItems.Add(new MenuItem("Редактировать", new EventHandler(delegate (Object o, EventArgs a)
                    {
                        int id = (int)Grid.Rows[currentMouseOverRow].Cells[0].Value;
                        var form = new MaterialForm(id, Models.EditMode.Edit);
                        form.ShowDialog();
                        RefreshGrid();
                    })));
                    m.MenuItems.Add(new MenuItem("Удалить", new EventHandler(delegate (Object o, EventArgs a)
                    {
                        int id = (int)Grid.Rows[currentMouseOverRow].Cells[0].Value;
                        if (MessageBox.Show("Вы точно хотите удалить этот элемент?", "Удалить?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            var context = new ApplicationDbContext();
                            //TODO удаление материала по ключу
                            context.Materials.Remove(context.Materials.FirstOrDefault(x => x.Id == id));
                            context.SaveChanges();
                        }
                        RefreshGrid();
                    })));
                }

                m.Show(Grid, new Point(e.X, e.Y));

            }
        }
        /// <summary>
        /// вызов формы для добаления материала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMaterial_Click(object sender, EventArgs e)
        {
            var form = new MaterialForm();
            form.ShowDialog();
            RefreshGrid();
        }
    }
}
