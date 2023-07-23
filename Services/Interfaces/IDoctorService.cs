using LunaServer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LunaServer.Services.Interfaces
{
    public interface IDoctorService
    {
        void EditDoctor(DoctorModel doctor);
        int AddDoctor(DoctorModel doctor);
        int RemoveDoctor(int id);
        DoctorModel GetDoctor(int id);
        ICollection<DoctorModel> GetHospitalDoctor(int HospitalId);
    }
}
