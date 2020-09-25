using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuiceShopEntities
{
    public class Juice
    {
        public string juice_flavor { get; set; }
        public int juice_id { get; set; }
        public int price { get; set; }
    }
    public class JuicePurchased
    {
        public int purchase_no { get; set; }
        public int juice_id { get; set; }
        public int quantity { get; set; }
        public int amount { get; set; }
    }
}
