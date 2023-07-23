using LunaServer.DAL.DBContext;
using LunaServer.DAL.Entities;
using LunaServer.DAL.Interface;
using LunaServer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LunaServer.DAL.Repository
{
    public class PharmacyRepository : AbstractRepository<PharmacyModel, int>, IPharmacyRepository
    {
        public PharmacyRepository(LunaDBContext context) : base(context) { }

        public override int Add(PharmacyModel data)
        {
            throw new System.NotImplementedException();
        }

        public override PharmacyModel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public override ICollection<PharmacyModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<PharmacyModel> GetHospitalPharmacy(int HospitalId)
        {
            var query = context.Pharmacies.Include(x=> x.Hospital).Where(x=> x.HospitalId == HospitalId).ToList();
            var data = query.Select(x => ToDomain(x));

            return data.ToList();
        }

        public override int Remove(int Id)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(PharmacyModel data)
        {
            throw new System.NotImplementedException();
        }

        public PharmacyModel ToDomain(Pharmacy source)
        {
            return new PharmacyModel
            {
                PharmacyId = source.PharmacyId,
                PharmacyName = source.PharmacyName,
                OpenTime = source.OpenTime,
                CloseTime = source.CloseTime,
                Status = source.Status,
                HospitalId = source.HospitalId,
                HospitalName = source.Hospital.HospitalName,
                PharmacyCode = source.PharmacyCode,
                TotalPrescription = 13
            };
        }

    }
}
