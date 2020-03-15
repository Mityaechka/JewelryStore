using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelryStore.Models
{
    public class MaterialCost
    {
        public int Id { get; set; }
        public decimal Weight { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }

    }
}
