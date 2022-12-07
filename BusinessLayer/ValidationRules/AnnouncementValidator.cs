using DTOLayer.DTOs.AnnouncementDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Duyuru içeriği boş geçilemez");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 karakter girilmesi gerekli");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("En az 20 karakter girilmesi gerekli");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("En fazla 50 karakter girilmesi gerekli");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("En fazla 500 karakter girilmesi gerekli");
        }
    }
}
