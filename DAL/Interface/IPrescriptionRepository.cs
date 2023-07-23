using LunaServer.Models;
using System.Collections.Generic;

namespace LunaServer.DAL.Interface
{
    public interface IPrescriptionRepository : IRepository<PrescriptionModel, int>
    {
        ICollection<PrescriptionModel> GetPharmacyPrescription(int PharmacyId);
        PrescriptionModel GetPrescription(int PrescriptionId);
    }
}
