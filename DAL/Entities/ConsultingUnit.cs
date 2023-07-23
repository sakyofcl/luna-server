using System;
using System.Collections.Generic;

namespace LunaServer.DAL.Entities
{
    public class ConsultingUnit
    {
        public int ConsultingUnitId { get; set;}
        public string UnitName { get; set;}
        public DateTimeOffset? OpenTime { get; set;}
        public DateTimeOffset? CloseTime { get; set;}
        public int? Status { get; set;}
        public int? HospitalId { get; set;}
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        public Hospital Hospital { get; set; }
        public ICollection<Queue> Queues { get; set; }
    }
}