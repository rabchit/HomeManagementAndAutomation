using AutoMapper;
using HomeManagementAndAutomation.Application.Contracts.Persistence.Common;
using HomeManagementAndAutomation.Application.DTOs.Products.Validator;
using HomeManagementAndAutomation.Application.Features.Products.Requests.Commands;
using HomeManagementAndAutomation.Application.Responses;
using HomeManagementAndAutomation.Domain.Entity;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeManagementAndAutomation.Application.Features.Products.Handlers.Commands
{
    public class CreateProductCommandHandler: IRequestHandler<CreateProductCommand, BaseCommandResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();
            var validator = new CreateProductDtoValidator();
            var validationResult = await validator.ValidateAsync(request.ProductDto);

            if (validationResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }
            else
            {
                var cash = _mapper.Map<Product>(request.ProductDto);

                cash = await _unitOfWork.ProductRepository.Add(cash);
                await _unitOfWork.Save();

                response.Success = true;
                response.Message = "Creation Successful";
                response.Id = cash.Id;
            }

            return response;
        }
    }
}