using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    internal class order
    {
        public int ID { get; set; }

        public string Shiped_Data { get; set; }

        public string Order_Data { get; set; }

        public byte Discount { get; set; }
        public int Unit_price { get; set; }
        public int Quantity { get; set; }
        public customer customer { get; set; }
    }
}
