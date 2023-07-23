using LunaServer.Models;
using System.Collections.Generic;

namespace LunaServer.Services.Interfaces
{
    public interface IPrescriptionService
    {
        ICollection<PrescriptionModel> GetPharmacyPrescription(int PharmacyId);
        PrescriptionModel GetPrescription(int PrescriptionId);
    }
}
