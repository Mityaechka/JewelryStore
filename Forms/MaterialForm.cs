using JewelryStore.Data;
using JewelryStore.Models;
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
    /// форма редактирования, добавления и обновления материала
    /// </summary>
    public partial class MaterialForm : Form
    {
        Material material = new Material();
        EditMode EditMode;
        public MaterialForm()
        {
            InitializeComponent();
            EditMode = EditMode.Create;
            mainBtn.Text = "Добавить";
        }
        public MaterialForm(int id,EditMode editMode)
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            //TODO получение материала по ключу
            material = context.Materials.SingleOrDefault(x => x.Id == id);
            NameT.Text = material.Name;
            GramCost.Value = material.GramCost;
            EditMode = editMode;
            if (editMode == EditMode.View)
            {
                Consists.Visible = true;
                mainBtn.Text = "Ок";
                NameT.Enabled = GramCost.Enabled= false;
            }
            else
            {
                mainBtn.Text = "Сохранить";
            }
        }
        /// <summary>
        /// сохрание или обновление записи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainBtn_Click(object sender, EventArgs e)
        {
            var context = new ApplicationDbContext();

            
            switch (EditMode)
            {
                case EditMode.Create:
                    material.Name = NameT.Text;
                    material.GramCost = GramCost.Value;
                    //TODO добавление нового материала
                    context.Materials.Add(material);
                    break;
                case EditMode.Edit:
                    //TODO получение материала по ключу для обновления данных
                    material = context.Materials.FirstOrDefault(x => x.Id == material.Id);
                    material.Name = NameT.Text;
                    material.GramCost = GramCost.Value;
                    break;
            }
            context.SaveChanges();
        }
        /// <summary>
        /// вызов формы для просмотра изделий
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Consists_Click(object sender, EventArgs e)
        {
            var form = new MaterialConsistsForm(material.Id);
            form.ShowDialog();
        }
    }
}
