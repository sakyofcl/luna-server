using System;
using System.Collections.Generic;

namespace LunaServer.DAL.Entities
{
    public class Pharmacy
    {
        public int PharmacyId { get; set;}
        public string PharmacyName { get; set;}
        public DateTimeOffset? OpenTime { get; set;}
        public DateTimeOffset? CloseTime { get; set;}
        public int? Status { get; set;}
        public int? HospitalId { get; set;}
        public string PharmacyCode { get; set;}
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        public Hospital Hospital { get; set;}
        public ICollection<Prescription> Prescriptions { get; set;}
    }
}