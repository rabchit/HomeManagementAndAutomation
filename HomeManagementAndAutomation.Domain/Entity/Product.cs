using HomeManagementAndAutomation.Domain.Entity.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Domain.Entity
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string PacketSize { get; set; }
        public List<ProductProperty> ProductProperties { get; set; }
    }
}
