using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryStore.Models
{
    public class Material
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal GramCost { get; set; }
        public string Data => $"{Name}({GramCost}/г.)";
    }
}
