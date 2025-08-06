using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhLinh.DataObject
{
    internal class AddCarDetailItems
    {
        public string ItemId { get; set; }
        public string Serial { get; set; }
        public decimal Quantity { get; set; }
        public DateTime ReplacementDate { get; set; }
        public decimal ReplacementKm { get; set; }
        public string Description { get; set; }
    }
}
