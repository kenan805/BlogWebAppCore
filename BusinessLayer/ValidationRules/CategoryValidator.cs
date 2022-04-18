using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x=>x.CategoryName).NotEmpty().WithMessage("Kateqoriya adı boş ola bilməz!");
            RuleFor(x=>x.CategoryDescription).NotEmpty().WithMessage("Kateqoriya təsviri boş ola bilməz!");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kateqoriya adı maksimum 50 hərfli ola bilər!");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Kateqoriya adı minimum 2 hərfli olmalıdır!");
        }
    }
}
