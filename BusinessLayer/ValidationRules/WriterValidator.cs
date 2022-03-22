using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazıçı adı boş olmamalıdır!");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail boş olmamalıdır!");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifrə boş olmamalıdır!");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Ad minimum 2 hərfli olmalıdır!");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Ad maksimum 50 hərfli ola bilər!");
        }
    }
}
