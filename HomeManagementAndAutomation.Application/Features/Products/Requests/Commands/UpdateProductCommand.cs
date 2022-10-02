using HomeManagementAndAutomation.Application.DTOs.Products;
using HomeManagementAndAutomation.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Application.Features.Products.Requests.Commands
{
    public class UpdateProductCommand : IRequest<BaseCommandResponse>
    {
        public ProductDto ProductDto { get; set; }
    }
}
