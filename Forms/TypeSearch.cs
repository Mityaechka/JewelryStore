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
    /// Форма поиска по типу
    /// </summary>
    public partial class TypeSearch : Form
    {
        public TypeSearch()
        {
            InitializeComponent();

            var context = new ApplicationDbContext();
            //TODO получение уникальных типов из таблицы изделий
            var types = context.Productions.Select(x => x.Type).Distinct().ToArray();
            Type.Items.Clear();
            Type.Items.AddRange(types);
            Type.SelectedIndex = 0;
        }
        /// <summary>
        /// Обновление таблицы
        /// </summary>
        /// <param name="t"></param>
        public void RefreshGrid(string t)
        {
            Grid.Rows.Clear();
            var context = new ApplicationDbContext();
            //TODO получение всех ихделий
            foreach (var m in context.Productions.Include(x=>x.MaterialCosts.Select(u=>u.Material)).Where(x=>x.Type==t).ToList())
            {
                Grid.Rows.Add(m.Id, m.Name,m.Weight,m.Cost);
            }
        }
        /// <summary>
        /// Вызов контекстного меню для таблицы
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
                    })));
                    m.MenuItems.Add(new MenuItem("Редактировать", new EventHandler(delegate (Object o, EventArgs a)
                    {
                        int id = (int)Grid.Rows[currentMouseOverRow].Cells[0].Value;
                        var form = new ProductionForm(id, Models.EditMode.Edit);
                        form.ShowDialog();
                    })));
                    m.MenuItems.Add(new MenuItem("Удалить", new EventHandler(delegate (Object o, EventArgs a)
                    {
                        int id = (int)Grid.Rows[currentMouseOverRow].Cells[0].Value;
                        if (MessageBox.Show("Вы точно хотите удалить этот элемент?", "Удалить?", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            try
                            {
                                var context = new ApplicationDbContext();
                                //TODO удаление записи по ключу
                                context.Productions.Remove(context.Productions.FirstOrDefault(x => x.Id == id));
                                context.SaveChanges();
                            }catch(Exception ex)
                            {
                                MessageBox.Show("Сначала необходимо удалить все связанные данные", "Ошибка");
                            }
                        }
                    })));
                }

                m.Show(Grid, new Point(e.X, e.Y));

            }
        }
        /// <summary>
        /// Поиск по типу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Search_Click(object sender, EventArgs e)
        {
            RefreshGrid((string)Type.SelectedItem);
        }
    }
}
