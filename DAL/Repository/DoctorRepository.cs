using LunaServer.DAL.DBContext;
using LunaServer.DAL.Entities;
using LunaServer.DAL.Interface;
using LunaServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LunaServer.DAL.Repository
{
    public class DoctorRepository : AbstractRepository<DoctorModel, int>, IDoctorRepository
    {
        public DoctorRepository(LunaDBContext context) : base(context) { }

        public override int Add(DoctorModel data)
        {
            var entity = ToEntity(data, new Doctor());
            context.Doctors.Add(entity);
            context.SaveChanges();
            return entity.DoctorId;
        }

        public override DoctorModel Get(int id)
        {
            var query = context.Doctors.Where(x => x.DoctorId == id).FirstOrDefault();
            if (query is not null)
            {
                return ToDomain(query);
            }
            return null;
        }


        public override ICollection<DoctorModel> GetAll()
        {
            var query = context.Doctors.ToList();
            var data = query.Select(x => ToDomain(x)).ToList();
            return data;
        }


        public override int Remove(int Id)
        {
            var entity = context.Doctors.FirstOrDefault(m => m.DoctorId == Id);
            if (entity is not null)
            {
                context.Doctors.Remove(entity);
                context.SaveChanges();
                return Id;
            }
            return 0;
        }

        public override void Update(DoctorModel data)
        {
            var doctorToUpdate = context.Doctors.FirstOrDefault(x => x.DoctorId == data.DoctorId);
            doctorToUpdate = ToEntity(data, doctorToUpdate);
            context.SaveChanges();
        }

        private static Doctor ToEntity(DoctorModel source, Doctor target)
        {
            target.DoctorId = source.DoctorId;
            target.DoctorName = source.DoctorName;
            target.Gender = source.Gender;
            target.PhoneNo = source.PhoneNo;
            target.Qualification = source.Qualification;
            target.Specialization = source.Specialization;
            target.Email = source.Email;
            target.Address = source.Address;
            target.DigitalSingnature = source.DigitalSingnature;
            target.HospitalId = source.HospitalId;

            return target;
        }

        private static DoctorModel ToDomain(Doctor target)
        {
            return new DoctorModel
            {
                DoctorId = target.DoctorId,
                DoctorName = target.DoctorName,
                Gender = target.Gender,
                PhoneNo = target.PhoneNo,
                Qualification = target.Qualification,
                Specialization = target.Specialization,
                Email = target.Email,
                Address = target.Address,
                DigitalSingnature = target.DigitalSingnature,
                HospitalId = target.HospitalId,
            };
        }

        public ICollection<DoctorModel> GetHospitalDoctor(int HospitalId)
        {
            var data = context.Doctors.Where(x => x.HospitalId == HospitalId).ToList();
            return data.Select(x => ToDomain(x)).ToList();
        }
    }
}
