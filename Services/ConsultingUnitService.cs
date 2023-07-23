using LunaServer.DAL.Entities;
using LunaServer.DAL.Interface;
using LunaServer.Models;
using LunaServer.Services.Interfaces;
using System.Collections.Generic;

namespace LunaServer.Services
{
    public class ConsultingUnitService : IConsultingUnitService
    {
        private IUnitOfWork _uow;
        public ConsultingUnitService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public int AddConsultingUnit(ConsultingUnitModel consultingUnit)
        {
            return _uow.ConsultingUnit.Add(consultingUnit);
        }

        public void EditConsultingUnit(ConsultingUnitModel consultingUnit)
        {
            _uow.ConsultingUnit.Update(consultingUnit);
        }

        public ConsultingUnitModel GetConsultingUnit(int id)
        {
            return _uow.ConsultingUnit.Get(id);
        }

        public ICollection<ConsultingUnitModel> GetHospitalUnits(int HospitalId)
        {
            return _uow.ConsultingUnit.GetHospitalUnits(HospitalId);
        }

        public ICollection<ConsultingUnitModel> GetHospitalUnitsForPatient(int PatientId)
        {
            return _uow.ConsultingUnit.GetHospitalUnitsForPatient(PatientId);
        }

        public int RemoveConsultingUnit(int id)
        {
            return _uow.ConsultingUnit.Remove(id);
        }
    }
}
