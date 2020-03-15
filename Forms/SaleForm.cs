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
    /// Форма продаж
    /// </summary>
    public partial class SaleForm : Form
    {
        Sale sale = new Sale();
        EditMode EditMode;
        List<Production> Productions = new List<Production>();
        public SaleForm()
        {
            InitializeComponent();
            EditMode = EditMode.Create;
            mainBtn.Text = "Добавить";
            var context = new ApplicationDbContext();
            //TODO получение уникальных имен из таблицы продаж
            var byers = context.Sales.Select(x => x.BuyerFullName).Distinct().ToArray();
            BuyerFullName.AutoCompleteMode = AutoCompleteMode.Suggest;
            BuyerFullName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection DataCollection = new AutoCompleteStringCollection();
            DataCollection.AddRange(byers);
            BuyerFullName.AutoCompleteCustomSource = DataCollection;
            //TODO получение всех записей с включением материалов
            Productions = context.Productions.Include(x=>x.MaterialCosts.Select(u=>u.Material)).ToList();
            Production.Items.Clear();
            Production.Items.AddRange(Productions.ToArray());
            Production.DisplayMember = "Name";
            Production.ValueMember = "Id";
            Production.SelectedIndex = 0;
        }
        public SaleForm(int id,EditMode editMode)
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            //TODO ппоиск продажи по ключу с сключением материалов
            sale = context.Sales.Include(x => x.Production.MaterialCosts.Select(u => u.Material)).SingleOrDefault(x => x.Id == id);
            BuyerFullName.Text = sale.BuyerFullName;
            SaleDate.Value = sale.SaleDate;
            Discount.Value = sale.Discount;
            EditMode = editMode;
            if (editMode == EditMode.View)
            {
                mainBtn.Text = "Ок";
                SaleDate.Enabled = Production.Enabled= false;
            }
            else
            {
                mainBtn.Text = "Сохранить";
            }
            BuyerFullName.Enabled = false;
            //TODO получение всех записей с включением материалов
            Productions = context.Productions.Include(x => x.MaterialCosts.Select(u => u.Material)).ToList();
            Production.Items.Clear();
            Production.Items.AddRange(Productions.ToArray());
            Production.DisplayMember = "Name";
            Production.ValueMember = "Id";
            Production.SelectedItem = sale.Production;
        }
        /// <summary>
        /// Функция для сохрания или обновления записи в базе данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainBtn_Click(object sender, EventArgs e)
        {
            var context = new ApplicationDbContext();

            var item = (Production)Production.SelectedItem;
            switch (EditMode)
            {
                case EditMode.Create:
                    sale.BuyerFullName = BuyerFullName.Text;
                    sale.SaleDate = SaleDate.Value;
                    sale.ProductionId = item.Id;
                    sale.Discount = Discount.Value;
                    //TODO добавление продажи
                    context.Sales.Add(sale);
                    break;
                case EditMode.Edit:
                    //TODO получение продажи по ключу для обновления записи
                    sale = context.Sales.FirstOrDefault(x => x.Id == sale.Id);
                    sale.BuyerFullName = BuyerFullName.Text;
                    sale.SaleDate = SaleDate.Value;
                    sale.ProductionId = item.Id;
                    sale.Discount = Discount.Value;
                    break;
            }
            context.SaveChanges();
        }
        /// <summary>
        /// Изменение имени в поле ввода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BuyerFullName_TextChanged(object sender, EventArgs e)
        {
            if (EditMode != EditMode.Create)
                return;
            try
            {
                var context = new ApplicationDbContext();
                var Buyer = BuyerFullName.Text;
                //TODO поиск продажи по имени покупателя
                var count = context.Sales.Where(x => x.BuyerFullName == Buyer).Count();
                if (count >= 3)
                    Discount.Value = 10;
                else
                    Discount.Value = 0;
                var item = (Production)Production.SelectedItem;
                Cost.Value = item.Cost;
                Total.Value = item.Cost - item.Cost * (Discount.Value/100);
            }catch(Exception ex) { }
        }
        /// <summary>
        /// Изменение продукции в выподающем меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Production_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var item = (Production)Production.SelectedItem;
                Cost.Value = item.Cost;
                Total.Value = item.Cost - item.Cost * (Discount.Value/100);
            }catch(Exception ex) { }
        }
    }
}
