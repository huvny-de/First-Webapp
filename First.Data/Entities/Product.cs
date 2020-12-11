using System;
using System.Collections.Generic;
using System.Text;

namespace First.Data.Entities
{
    public class Product
    {
        public int Id { set; get; }
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public int ViewCount { set; get; }
        public DateTime DataCreated { set; get; }
        public String SeoAlias { set; get; }
    }
}
