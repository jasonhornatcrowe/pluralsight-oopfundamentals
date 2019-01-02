using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product
    {
        public Product() { }
        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; private set; }
        public Decimal? CurrentPrice { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }

        public bool Validate()
        {
            var isValid = !string.IsNullOrWhiteSpace(Name);
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
