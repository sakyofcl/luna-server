using LunaServer.Models;
using System.Collections.Generic;

namespace LunaServer.DAL.Interface
{
    public interface IPharmacyRepository : IRepository<PharmacyModel, int>
    {
        ICollection<PharmacyModel> GetHospitalPharmacy(int HospitalId);
    }
}
