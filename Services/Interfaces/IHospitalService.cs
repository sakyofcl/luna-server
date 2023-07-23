using LunaServer.Models;
using System.Collections.Generic;

namespace LunaServer.Services.Interfaces
{
    public interface IHospitalService
    {
        ICollection<HospitalModel> GetAll();
        HospitalModel Get(int HospitalId);
    }
}
