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
    public class QueueRepository : AbstractRepository<QueueModel, int>, IQueueRepository
    {
        public QueueRepository(LunaDBContext context) : base(context) { }

        public override int Add(QueueModel data)
        {
            var entity = ToEntity(data, new Queue());
            context.Queues.Add(entity);
            context.SaveChanges();
            return entity.QueueId;
        }

        public override QueueModel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public override ICollection<QueueModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public override int Remove(int Id)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(QueueModel data)
        {
            throw new System.NotImplementedException();
        }
        public ICollection<AppointmentModel> GetAppointments(int ConsultingUnitId)
        {
            var query = context.Queues.Include(p=> p.Patient).Where(x=> x.ConsultingUnitId == ConsultingUnitId).ToList();
            var data = query.Select(x=> ToDomain(x)).ToList();
            return data;
        }

        private static Queue ToEntity(QueueModel source, Queue target)
        {
            target.QueueId = source.QueueId;
            target.ConsultingUnitId = source.ConsultingUnitId;
            target.PatientId = source.PatientId;
            target.Priority = source.Priority;
            target.RequestTime = source.RequestTime;
            target.EstimatedWaitTime = source.EstimatedWaitTime;
            target.CompletionTime = source.CompletionTime;
            target.PickBy = source.PickBy;
            target.CompleteBy = source.CompleteBy;
            target.Notes = source.Notes;
            target.Status = source.Status;
       
            return target;
        }

        private static AppointmentModel ToDomain(Queue queue)
        {
            return new AppointmentModel
            {
                AppointmentNumber = queue.QueueId,
                AppointmentStatus = queue.Status ?? 0,
                PatientName = queue.Patient.PatientName,
                PatientId = queue.PatientId ?? 0,
                PatientProfile = "https://www.behindwoods.com/tamil-actress/sri-divya/sri-divya-stills-photos-pictures-590.jpg",
                RequestTime = queue.RequestTime,
                EstimatedWaitTime = queue.EstimatedWaitTime,
                CompletionTime = queue.CompletionTime,
                Priority = queue.Priority ?? 0,
                ConsultingUnitId = queue.ConsultingUnitId ?? 0,
                Gender = queue.Patient.Gender ?? 0,
            };
        }

        public AppointmentModel GetAppointment(int AppointmentNumber)
        {
            var query = context.Queues.Include(p => p.Patient).Where(x => x.QueueId == AppointmentNumber).FirstOrDefault();
            if (query is not null)
            {
                return ToDomain(query);
            }
            return null;
        }
    }
}
