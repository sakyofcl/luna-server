using System;

namespace LunaServer.Models
{
    public class PharmacyModel
    {
        public int PharmacyId { get; set; }
        public string PharmacyName { get; set; }
        public DateTimeOffset? OpenTime { get; set; }
        public DateTimeOffset? CloseTime { get; set; }
        public int? Status { get; set; }
        public int? HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string PharmacyCode { get; set; }
        public int TotalPrescription { get; set; }
    }
}
