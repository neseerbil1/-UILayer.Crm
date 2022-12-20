using Crm.BusinessLayer.Absract;
using Crm.BusinessLayer.Concrete;
using Crm.BusinessLayer.ValidationRules.AnnouncementValidationRules;
using Crm.DataAccessLayer.Abstract;
using Crm.DataAccessLayer.EntityFrameWork;
using Crm.DTO.DTOs.AnnouncementDtos;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Crm.BusinessLayer.DIContainer
{
    public static class Extension
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeManager>();
            services.AddScoped<IEmployeeDal, EfEmployeeDal>();

            services.AddScoped<IMessageService, MessageManager>();
            services.AddScoped<IMessageDal, EfMessageDal>();
            // her kullanıcı için bir CategoryManager nesnesi oluşturulur.
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();

            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
        }
        public static void DtoValidator(this IServiceCollection services)
        {
            //transient metodunda her istek için hizmet yeniden oluşturulur ve istek bitince yok edilir
            services.AddTransient<IValidator<AnnouncementAddDto>, AnnouncementAddValidator>();
            services.AddTransient<IValidator<AnnouncementUpdateDto>, AnnouncementUpdateValidator>();
        }
    }
}
