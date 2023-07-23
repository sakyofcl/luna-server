using LunaServer.DAL.Interface;
using LunaServer.Models;
using LunaServer.Services.Interfaces;
using System.Collections.Generic;

namespace LunaServer.Services
{
    public class PharmacyService : IPharmacyService
    {
        private IUnitOfWork _uow;
        public PharmacyService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ICollection<PharmacyModel> GetHospitalPharmacy(int HospitalId)
        {
            return _uow.Pharmacy.GetHospitalPharmacy(HospitalId);
        }
    }
}
