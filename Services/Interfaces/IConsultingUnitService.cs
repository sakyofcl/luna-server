using LunaServer.Models;
using System.Collections.Generic;

namespace LunaServer.Services.Interfaces
{
    public interface IConsultingUnitService
    {
        ICollection<ConsultingUnitModel> GetHospitalUnits(int HospitalId);
        ICollection<ConsultingUnitModel> GetHospitalUnitsForPatient(int PatientId);

        void EditConsultingUnit(ConsultingUnitModel consultingUnit);
        int AddConsultingUnit(ConsultingUnitModel consultingUnit);
        int RemoveConsultingUnit(int id);
        ConsultingUnitModel GetConsultingUnit(int id);
    }
}
