using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtos.Products
{
    public class PeoductDetailesDto
    {

        public Guid ID { get; set; }

        public string Name { get; set; }

        public string imageUrl { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public byte Discount { get; set; }
        public float UnitWeight { get; set; }
        public float Price { get; set; }
    }
}
