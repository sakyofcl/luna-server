using LunaServer.DAL.DBContext;
using LunaServer.DAL.Entities;
using LunaServer.DAL.Interface;
using LunaServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LunaServer.DAL.Repository
{
    public class ConsultingUnitRepository : AbstractRepository<ConsultingUnitModel, int>, IConsultingUnitRepository
    {
        public ConsultingUnitRepository(LunaDBContext context) : base(context) { }

        public override int Add(ConsultingUnitModel data)
        {
            var entity = ToEntity(data, new ConsultingUnit());
            context.ConsultingUnits.Add(entity);
            context.SaveChanges();
            return entity.ConsultingUnitId;
        }

        public override ConsultingUnitModel Get(int id)
        {
            var query = context.ConsultingUnits.Where(x => x.ConsultingUnitId == id).FirstOrDefault();
            if (query is not null)
            {
                return ToDomain(query);
            }
            return null;
        }

        public override ICollection<ConsultingUnitModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ICollection<ConsultingUnitModel> GetHospitalUnits(int HospitalId)
        {
            var data = context.ConsultingUnits.Where(x => x.HospitalId == HospitalId).ToList();
            return data.Select(x => ToDomain(x)).ToList();
        }

        public override int Remove(int Id)
        {
            var entity = context.ConsultingUnits.FirstOrDefault(m => m.ConsultingUnitId == Id);
            if (entity is not null)
            {
                context.ConsultingUnits.Remove(entity);
                context.SaveChanges();
                return Id;
            }
            return 0;
        }

        public override void Update(ConsultingUnitModel data)
        {
            var consultingUnitToUpdate = context.ConsultingUnits.FirstOrDefault(x => x.ConsultingUnitId == data.ConsultingUnitId);
            consultingUnitToUpdate = ToEntity(data, consultingUnitToUpdate);
            context.SaveChanges();
        }

        public ConsultingUnitModel ToDomain(ConsultingUnit source)
        {
            return new ConsultingUnitModel
            {
                HospitalId = source.HospitalId,
                UnitName = source.UnitName,
                OpenTime = source.OpenTime,
                CloseTime = source.CloseTime,
                Status = source.Status,
                ConsultingUnitId = source.ConsultingUnitId,
                currentAppoinmentCount = 12
            };
        }

        private static ConsultingUnit ToEntity(ConsultingUnitModel source, ConsultingUnit target)
        {
            target.ConsultingUnitId = source.ConsultingUnitId;
            target.HospitalId = source.HospitalId;
            target.UnitName = source.UnitName;
            target.OpenTime = source.OpenTime;
            target.CloseTime = source.CloseTime;
            target.Status = source.Status;
            
            return target;
        }


        public ICollection<ConsultingUnitModel> GetHospitalUnitsForPatient(int PatientId)
        {
            var data = context.ConsultingUnits.Include(x=> x.Queues).Where(y=> y.Queues.Any(z => z.PatientId==PatientId)).ToList();
            return data.Select(x => ToDomain(x)).ToList();
        }
    }
}
