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
    /// форма изделий
    /// </summary>
    public partial class ProductionForm : Form
    {
        Production production = new Production();
        EditMode EditMode;
        List<Material> Materials = new List<Material>();
        public ProductionForm()
        {
            InitializeComponent();
            EditMode = EditMode.Create;

            mainBtn.Text = "Добавить";
            var  context = new ApplicationDbContext();
            //TODO получение всех материалов
            Materials = context.Materials.ToList();
            MaterialC.Items.Clear();
            MaterialC.Items.AddRange(Materials.ToArray());
            MaterialC.DisplayMember = "Data";
            MaterialC.ValueMember = "Id";
        }
        public ProductionForm(int id,EditMode editMode)
        {
            InitializeComponent();
           

            EditMode = editMode;
            if (editMode == EditMode.View)
            {
                mainBtn.Text = "Ок";
                NameT.Enabled = Weight.Enabled=Cost.Enabled= materialGrid.Enabled=Type.Enabled= false;
            }
            else
            {
                mainBtn.Text = "Сохранить";
            }
            var context = new ApplicationDbContext();
            //TODO получение продукции по ключу с включение материалов
            production = context.Productions
                .Include(x=>x.MaterialCosts.Select(u=>u.Material))
                .SingleOrDefault(x => x.Id == id);
            //TODO получение всех материалов
            Materials = context.Materials.ToList();

            MaterialC.Items.Clear();
            MaterialC.Items.AddRange(Materials.ToArray());
            MaterialC.DisplayMember = "Data";
            MaterialC.ValueMember = "Id";

            materialGrid.Rows.Clear();
            foreach(var m in production.MaterialCosts)
            {
                materialGrid.Rows.Add( m.Material.Id, m.Weight);
            }
            NameT.Text = production.Name;
            Type.Text = production.Type;
            Cost.Value = production.Cost;
            Weight.Value = production.Weight;
        }
        /// <summary>
        /// Сохрание или обновление записи в базе данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainBtn_Click(object sender, EventArgs e)
        {
            var context = new ApplicationDbContext();

            switch (EditMode)
            {
                case EditMode.Create:
                    production.Name = NameT.Text;
                    production.Type = Type.Text;
                    production.MaterialCosts = new List<MaterialCost>();
                    foreach (DataGridViewRow c in materialGrid.Rows)
                    {
                        try
                        {
                            var id = (int)c.Cells[0].Value;
                            var m = Materials.FirstOrDefault(x => x.Id == id);
                            var cost = m.GramCost * Convert.ToDecimal(c.Cells[1].Value);
                            var w = Convert.ToDecimal(c.Cells[1].Value);
                            production.MaterialCosts.Add(new MaterialCost() { MaterialId = m.Id, Weight = w });
                        }
                        catch (Exception ex) { }
                    }
                    //TODO добавление новой продукции
                    context.Productions.Add(production);
                    break;
                case EditMode.Edit:
                    //TODO получение продукции по ключу для обновления записи
                    production = context.Productions.FirstOrDefault(x => x.Id == production.Id);
                    production.Name = NameT.Text;
                    production.Type = Type.Text;
                    context.MaterialCosts.RemoveRange(production.MaterialCosts);
                    foreach (DataGridViewRow c in materialGrid.Rows)
                    {
                        try
                        {
                            var id = (int)c.Cells[0].Value;
                            var m = Materials.FirstOrDefault(x => x.Id == id);
                            var cost = m.GramCost * Convert.ToDecimal(c.Cells[1].Value);
                            var w = Convert.ToDecimal(c.Cells[1].Value);
                            production.MaterialCosts.Add(new MaterialCost() { MaterialId = m.Id, Weight = w });
                        }
                        catch (Exception ex) { }
                    }
                    break;
            }
            context.SaveChanges();
        }
        /// <summary>
        /// контестное меню для таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal cost = 0,w=0;


            foreach(DataGridViewRow c in materialGrid.Rows)
            {
                try
                {
                    var id = (int)c.Cells[0].Value;
                    var m= Materials.FirstOrDefault(x => x.Id == id);
                    cost += m.GramCost * Convert.ToDecimal(c.Cells[1].Value);
                    w += Convert.ToDecimal(c.Cells[1].Value);
                }
                catch (Exception ex) { }
            }
            Weight.Value = w;
            Cost.Value = cost+cost*(decimal)0.1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Weight_ValueChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// удаление строки из таблицы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            decimal cost = 0, w = 0;


            foreach (DataGridViewRow c in materialGrid.Rows)
            {
                try
                {
                    var id = (int)c.Cells[0].Value;
                    var m = Materials.FirstOrDefault(x => x.Id == id);
                    cost += m.GramCost * Convert.ToDecimal(c.Cells[1].Value);
                    w += Convert.ToDecimal(c.Cells[1].Value);
                }
                catch (Exception ex) { }
            }
            Weight.Value = w;
            Cost.Value = cost + cost * (decimal)0.1;
        }
    }
}
