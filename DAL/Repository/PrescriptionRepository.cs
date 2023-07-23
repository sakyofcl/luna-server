using LunaServer.DAL.DBContext;
using LunaServer.DAL.Entities;
using LunaServer.DAL.Interface;
using LunaServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LunaServer.DAL.Repository
{
    public class PrescriptionRepository : AbstractRepository<PrescriptionModel, int>, IPrescriptionRepository
    {
        public PrescriptionRepository(LunaDBContext context) : base(context) { }

        public override int Add(PrescriptionModel data)
        {
            throw new System.NotImplementedException();
        }

        public override PrescriptionModel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public override ICollection<PrescriptionModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<PrescriptionModel> GetPharmacyPrescription(int PharmacyId)
        {
            var query = context.Prescriptions.Include(x=>x.Patient).Include(x=> x.Doctor).Where(x=> x.PharmacyId == PharmacyId).ToList();
            var data = query.Select(x => ToDomain(x));

            return data.ToList();
        }

        public override int Remove(int Id)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(PrescriptionModel data)
        {
            throw new System.NotImplementedException();
        }

        public PrescriptionModel ToDomain(Prescription source)
        {
            return new PrescriptionModel
            {
                PrescriptionId = source.PrescriptionId,
                PrescriptionDate = source.PrescriptionDate,
                isCollected = source.isCollected,
                DoctorId = source.Doctor.DoctorId,
                DoctorName = source.Doctor.DoctorName,
                PatientId = source.Patient.PatientId,
                PatientName = source.Patient.PatientName,
                ReferenceNumber = 1021
            };
        }

        public PrescriptionModel GetPrescription(int PrescriptionId)
        {
            var query = context.Prescriptions.Include(x => x.Patient).Include(x => x.Doctor).Where(x => x.PrescriptionId == PrescriptionId).FirstOrDefault();
            if (query is not null)
            {
                return ToDomain(query);
            }
            return null;
        }
    }
}
