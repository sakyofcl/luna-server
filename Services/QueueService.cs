using LunaServer.DAL.Interface;
using LunaServer.Models;
using LunaServer.Services.Interfaces;
using System.Collections.Generic;

namespace LunaServer.Services
{
    public class QueueService : IQueueService
    {
        private IUnitOfWork _uow;
        public QueueService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public int AddQueue(QueueModel queue)
        {
            return _uow.Queue.Add(queue);
        }

        public AppointmentModel GetAppointment(int AppointmentNumber)
        {
            return _uow.Queue.GetAppointment(AppointmentNumber);
        }

        public ICollection<AppointmentModel> GetAppointments(int ConsultingUnitId)
        {
            return _uow.Queue.GetAppointments(ConsultingUnitId);
        }
    }
}
