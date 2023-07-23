using LunaServer.Models;
using System.Collections.Generic;

namespace LunaServer.DAL.Interface
{
    public interface IDoctorRepository : IRepository<DoctorModel, int>
    {
        ICollection<DoctorModel> GetHospitalDoctor(int HospitalId);
    }
}
