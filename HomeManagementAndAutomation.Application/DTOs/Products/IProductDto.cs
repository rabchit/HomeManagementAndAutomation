using HomeManagementAndAutomation.Application.DTOs.ProductProperties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Application.DTOs.Products
{
    public interface IProductDto
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string PacketSize { get; set; }
    }
}
