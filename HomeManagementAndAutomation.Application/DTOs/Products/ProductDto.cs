using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Application.DTOs.Products
{
    public class ProductDto:IProductDto
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string PacketSize { get; set; }
        public List<ProductPropertiesDto> ProductProperties { get; set; }
    }
}
