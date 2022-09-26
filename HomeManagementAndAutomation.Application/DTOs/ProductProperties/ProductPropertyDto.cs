using HomeManagementAndAutomation.Application.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Application.DTOs.ProductProperties
{
    public class ProductPropertyDto:IProductPropertyDto
    {
        public ProductDto Product { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Currency { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
