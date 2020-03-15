using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryStore.Models
{
    public class Production
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual List<MaterialCost> MaterialCosts { get; set; } = new List<MaterialCost>();
        public decimal Weight => MaterialCosts.Sum(x =>x.Weight);
        public decimal Cost => MaterialCosts.Sum(x => x.Material.GramCost * x.Weight)+ 
            MaterialCosts.Sum(x => x.Material.GramCost * x.Weight)*(decimal)0.1;

    }
}
