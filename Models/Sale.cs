using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryStore.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public int ProductionId { get; set; }
        public Production Production { get; set; }
        public string BuyerFullName { get; set; }
        public decimal Discount { get; set; }
        public decimal Total => Production.Cost - Production.Cost *( Discount/100);
    }
}
