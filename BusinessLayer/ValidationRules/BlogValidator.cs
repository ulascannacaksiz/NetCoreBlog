using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog başlığını boş geçemezsiniz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz.");
            RuleFor(x => x.BlogThumbnailImage).NotEmpty().WithMessage("Blog resmini boş geçemezsiniz.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 karakterden az bir başlık giriniz");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lütfen 5 karakterden fazla bir başlık giriniz");
        }
    }
}
