using Entities.Dtos.ProductDtos;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductAddDtoValidator : AbstractValidator<ProductAddDto>
    {
        public ProductAddDtoValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("ad alanı boş geçilemez");
        }
    }
}
