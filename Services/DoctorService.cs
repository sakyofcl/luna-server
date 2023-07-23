using LunaServer.DAL.Interface;
using LunaServer.Models;
using LunaServer.Services.Interfaces;
using System.Collections.Generic;

namespace LunaServer.Services
{
    public class DoctorService : IDoctorService
    {
        private IUnitOfWork _uow;
        public DoctorService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public int AddDoctor(DoctorModel doctor)
        {
            return _uow.Doctor.Add(doctor);
        }

        public void EditDoctor(DoctorModel doctor)
        {
            _uow.Doctor.Update(doctor);
        }

        public DoctorModel GetDoctor(int id)
        {
            return _uow.Doctor.Get(id);
        }

        public ICollection<DoctorModel> GetHospitalDoctor(int HospitalId)
        {
            return _uow.Doctor.GetHospitalDoctor(HospitalId);
        }

        public int RemoveDoctor(int id)
        {
            return _uow.Doctor.Remove(id);
        }
    }
}
