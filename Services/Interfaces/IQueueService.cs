using LunaServer.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LunaServer.Services.Interfaces
{
    public interface IQueueService
    {
        int AddQueue(QueueModel queue);
        ICollection<AppointmentModel> GetAppointments(int ConsultingUnitId);
        AppointmentModel GetAppointment(int AppointmentNumber);
    }
}
