using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Bloq başlığı boş ola bilməz!");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Bloq kontenti boş ola bilməz!");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Bloq şəkili boş ola bilməz!");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Bloq başlığı maksimum 50 hərfli ola bilər!");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Bloq başlığı minimum 5 hərfli olmal;dr!");
        }
    }
}
