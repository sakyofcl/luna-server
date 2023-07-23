using System;

namespace LunaServer.Models
{
    public class ConsultingUnitModel
    {
        public int ConsultingUnitId { get; set; }
        public string UnitName { get; set; }
        public DateTimeOffset? OpenTime { get; set; }
        public DateTimeOffset? CloseTime { get; set; }
        public int? Status { get; set; }
        public int? HospitalId { get; set; }
        public int currentAppoinmentCount { get; set; }
    }
}
