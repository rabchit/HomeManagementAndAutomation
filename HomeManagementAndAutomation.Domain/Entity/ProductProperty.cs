using HomeManagementAndAutomation.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Domain.Entity
{
    public class ProductProperty:BaseDomainEntity
    {
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
