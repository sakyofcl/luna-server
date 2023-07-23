using LunaServer.DAL.Interface;
using LunaServer.Models;
using LunaServer.Services.Interfaces;
using System.Collections.Generic;

namespace LunaServer.Services
{
    public class PrescriptionService : IPrescriptionService
    {
        private IUnitOfWork _uow;
        public PrescriptionService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public ICollection<PrescriptionModel> GetPharmacyPrescription(int PharmacyId)
        {
            return _uow.Prescription.GetPharmacyPrescription(PharmacyId);
        }

        public PrescriptionModel GetPrescription(int PrescriptionId)
        {
           return _uow.Prescription.GetPrescription(PrescriptionId);
        }
    }
}
