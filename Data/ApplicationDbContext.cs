using JewelryStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryStore.Data
{
    /// <summary>
    /// КОнтекст для взаимодействия с базой данных
    /// </summary>
    public class ApplicationDbContext:DbContext
    {
        /// <summary>
        /// Набор пользователей
        /// </summary>
        public DbSet<User> Users { get; set; }
        /// <summary>
        /// Набор пользователей
        /// </summary>
        public DbSet<Material> Materials { get; set; }
        /// <summary>
        /// Набор продаж
        /// </summary>
        public DbSet<Sale> Sales { get; set; }
        /// <summary>
        /// Набор изделий
        /// </summary>
        public DbSet<Production> Productions { get; set; }
        /// <summary>
        /// Набор цен на метериалы
        /// </summary>
        public DbSet<MaterialCost> MaterialCosts { get; set; }
        public ApplicationDbContext()
            : base("DbConnection")
        {
            //TODO создание учетной записи, если ни одной не найдено
            if (Users.Count() == 0)
            {
                //TODO добавление пользователя
                Users.Add(new User() { Login = "Admin", Password = "123456", Name = "Администратор" });
                SaveChanges();
            }
        }
    }
}
