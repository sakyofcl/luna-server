using System;

namespace LunaServer.Models
{
    public class AppointmentModel
    {
        public string PatientName { get; set; }
        public int PatientId { get; set;}
        public int AppointmentNumber { get; set;}
        public int Gender { get; set;}
        public string PatientProfile { get; set;}
        public int AppointmentStatus { get; set; }
        public int Priority { get; set; }
        public int ConsultingUnitId { get; set; }
        public DateTimeOffset? RequestTime { get; set; }
        public DateTimeOffset? EstimatedWaitTime { get; set; }
        public DateTimeOffset? CompletionTime { get; set; }
    }
}
