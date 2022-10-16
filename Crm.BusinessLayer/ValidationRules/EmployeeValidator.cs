using Crm.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.BusinessLayer.ValidationRules
{
    public class EmployeeValidator:AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.EmployeeName).NotEmpty().WithMessage("Personel Adı Boş Geçilemez");
            RuleFor(x => x.EmployeeSurname).NotEmpty().WithMessage("Personel Soyadı Boş Geçilemez");
            RuleFor(x => x.EmployeeMail).NotEmpty().WithMessage("Personel Mail Boş Geçilemez");
            RuleFor(x => x.EmployeePassword).NotEmpty().WithMessage("Personel Şifresi Boş Geçilemez");
            RuleFor(x => x.EmployeeGender).NotEmpty().WithMessage("Personel Cinsiyet Boş Geçilemez");
            RuleFor(x => x.EmployeeName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter veri giriniz");
            RuleFor(x => x.EmployeeSurname).MaximumLength(20).WithMessage("Lütfen en fazla 20 karakter veri giriniz");


        }

    }
}
