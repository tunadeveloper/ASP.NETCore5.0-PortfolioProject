using FluentValidation;
using PortfolioProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioProject.BusinessLayer.ValidationRules
{
    public class PortfolioValidator:AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Portföy adı boş geçilemez.")
                .MinimumLength(3).WithMessage("Portföy adı en az 3 karakter olmalıdır.")
                .MaximumLength(50).WithMessage("Portföy adı en fazla 50 karakter olmalıdır.");

            RuleFor(x=>x.ImageUrl).NotEmpty().WithMessage("Portföy resmi boş geçilemez.")
                .MinimumLength(3).WithMessage("Portföy resmi en az 3 karakter olmalıdır.")
                .MaximumLength(250).WithMessage("Portföy resmi en fazla 250 karakter olmalıdır.");

            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Portföy resmi boş geçilemez.")
               .MinimumLength(3).WithMessage("Portföy resmi en az 3 karakter olmalıdır.")
               .MaximumLength(250).WithMessage("Portföy resmi en fazla 250 karakter olmalıdır.");

            RuleFor(x=>x.ProjectUrl).Length(3, 250).WithMessage("Proje URL'si en az 3, en fazla 250 karakter olmalıdır.")
                .Matches(@"^(http|https)://").WithMessage("Proje URL'si geçerli bir URL formatında olmalıdır.");
        }
    }
}
