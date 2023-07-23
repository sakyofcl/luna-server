using LunaServer.DAL.Interface;
using LunaServer.Models;
using LunaServer.Services.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace LunaServer.Services
{
    public class HospitalService : IHospitalService
    {
        private IUnitOfWork _uow;
        public HospitalService(IUnitOfWork uow) {
            _uow = uow;
        }

        public HospitalModel Get(int HospitalId)
        {
            return _uow.Hospital.Get(HospitalId);
        }

        public ICollection<HospitalModel> GetAll()
        {
            return _uow.Hospital.GetAll();
        }
    }
}
