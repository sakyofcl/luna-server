using Microsoft.Extensions.DependencyInjection;
using LunaServer.Services.Interfaces;
using LunaServer.Services;
using LunaServer.DAL.DBContext;
using Microsoft.EntityFrameworkCore;
using LunaServer.DAL.Interface;
using LunaServer.DAL.Uow;
namespace LunaServer.DiContainer{
    public class DiContainerRegister{
        public static void RegisterAllContainer(IServiceCollection services){
            services.AddTransient<ITestService, TestService>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IHospitalService, HospitalService>();
            services.AddTransient<IConsultingUnitService, ConsultingUnitService>();
            services.AddTransient<IQueueService, QueueService>();
            services.AddTransient<IPharmacyService, PharmacyService>();
            services.AddTransient<IPrescriptionService , PrescriptionService>();
            services.AddTransient<IDoctorService, DoctorService>();
        }
    }
}