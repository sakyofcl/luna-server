using LunaServer.Models;
using System.Collections.Generic;

namespace LunaServer.Services.Interfaces
{
    public interface IPharmacyService
    {
       ICollection<PharmacyModel> GetHospitalPharmacy(int HospitalId);
    }
}
