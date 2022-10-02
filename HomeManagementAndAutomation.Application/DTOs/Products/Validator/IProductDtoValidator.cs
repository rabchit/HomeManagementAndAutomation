using FluentValidation;
using System.Data;

namespace HomeManagementAndAutomation.Application.DTOs.Products.Validator
{
    public class IProductDtoValidator : AbstractValidator<IProductDto>
    {
        public IProductDtoValidator()
        {
            RuleFor(p => p.ProductName)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}