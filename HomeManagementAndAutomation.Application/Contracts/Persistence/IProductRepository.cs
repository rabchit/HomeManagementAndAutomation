using HomeManagementAndAutomation.Application.Contracts.Persistence.Common;
using HomeManagementAndAutomation.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Application.Contracts.Persistence
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        Task<List<Product>> GetByName(string name);
    }
}
