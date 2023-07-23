using LunaServer.DAL.DBContext;
using LunaServer.DAL.Entities;
using LunaServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LunaServer.DAL.Repository
{
    public class HospitalRepository : AbstractRepository<HospitalModel, int>
    {
        public HospitalRepository(LunaDBContext context) : base(context) { }

        public override int Add(HospitalModel data)
        {
            throw new System.NotImplementedException();
        }

        public override HospitalModel Get(int id)
        {
            var hospital = context.Hospitals.Where(x => x.HospitalId == id).FirstOrDefault();
            if (hospital is not null)
            {
                return ToDomain(hospital);
            }
            return null;
        }

        public override ICollection<HospitalModel> GetAll()
        {
            var query = context.Hospitals.ToList();
            var data = query.Select(x => ToDomain(x));

            return data.ToList();
        }

        public override int Remove(int Id)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(HospitalModel data)
        {
            throw new System.NotImplementedException();
        }
        public HospitalModel ToDomain (Hospital source)
        {
            return new HospitalModel{
                HospitalId = source.HospitalId,
                HospitalName = source.HospitalName,
                RegistrationNo = source.RegistrationNo,
                Description = source.Description,
                PhoneNumber = source.PhoneNumber,
                OfficeEmail = source.OfficeEmail,
                HospitalAddress = source.HospitalAddress,
                isActive = source.isActive
            };
        }
    }
}
