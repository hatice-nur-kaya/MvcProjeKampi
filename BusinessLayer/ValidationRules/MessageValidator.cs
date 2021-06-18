using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
   public class MessageValidator :AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı adresi Adı Boş Olamaz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Adı Boş Olamaz.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj  Boş Olamaz.");
            RuleFor(x => x.ReceiverMail).EmailAddress().WithMessage("Geçerli bir e-posta değeri giriniz!").When(i => !string.IsNullOrEmpty(i.ReceiverMail));
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Lütfen 100 karakterden fazla değer girişi yapmayınız.");

        }
    }
}
