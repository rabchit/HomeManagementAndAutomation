using HomeManagementAndAutomation.Application.Contracts.Persistence.Common;
using HomeManagementAndAutomation.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Application.Contracts.Persistence
{
    public interface IProductPropertyRepository:IGenericRepository<ProductProperty>
    {
    }
}
