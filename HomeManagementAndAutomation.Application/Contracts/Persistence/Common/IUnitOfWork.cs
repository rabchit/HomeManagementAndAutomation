using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Application.Contracts.Persistence.Common
{
    public interface IUnitOfWork:IDisposable
    {
        IProductPropertyRepository ProductPropertyRepository { get; }
        IProductRepository ProductRepository { get; }
        Task Save();
    }
}
