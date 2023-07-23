using System;

namespace LunaServer.Models
{
    public class QueueModel
    {
        public int QueueId { get; set; }
        public int? ConsultingUnitId { get; set; }
        public int? PatientId { get; set; }
        public int? Priority { get; set; }
        public DateTimeOffset? RequestTime { get; set; }
        public DateTimeOffset? EstimatedWaitTime { get; set; }
        public DateTimeOffset? CompletionTime { get; set; }
        public int? PickBy { get; set; }
        public int? CompleteBy { get; set; }
        public string Notes { get; set; }
        public int? Status { get; set; }
    }
}
