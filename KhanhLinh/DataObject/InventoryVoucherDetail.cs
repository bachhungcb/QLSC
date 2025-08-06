using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhanhLinh.DataObject
{
    internal class InventoryVoucherDetail
    {
        public string ItemId { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public decimal Quantity { get; set; }
        public string WarehouseCode { get; set; }
        public string CarCode { get; set; }
    }
}
