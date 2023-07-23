using LunaServer.Models;
using System.Collections.Generic;

namespace LunaServer.DAL.Interface
{
    public interface IQueueRepository : IRepository<QueueModel, int>
    {
        ICollection<AppointmentModel> GetAppointments(int ConsultingUnitId);
        AppointmentModel GetAppointment(int AppointmentNumber);
    }
}
