using LunaServer.Models;
using System.Collections.Generic;

namespace LunaServer.DAL.Interface
{
    public interface IConsultingUnitRepository : IRepository<ConsultingUnitModel, int>
    {
        ICollection<ConsultingUnitModel> GetHospitalUnits(int HospitalId);
        ICollection<ConsultingUnitModel> GetHospitalUnitsForPatient(int PatientId);
    }
}
