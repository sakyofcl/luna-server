using System;

namespace LunaServer.DAL.Entities
{
    public class Queue
    {
        public int QueueId { get; set;}
        public int? ConsultingUnitId { get; set;}
        public int? PatientId { get; set;}
        public int? Priority { get; set;}
        public DateTimeOffset? RequestTime { get; set;}
        public DateTimeOffset? EstimatedWaitTime { get; set;}
        public DateTimeOffset? CompletionTime { get; set;}
        public int? PickBy { get; set;}
        public int? CompleteBy { get; set;}
        public string Notes { get; set;}
        public int? Status { get; set;}
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        public Patient Patient { get; set;}
        public ConsultingUnit ConsultingUnit { get; set;}
    }
}