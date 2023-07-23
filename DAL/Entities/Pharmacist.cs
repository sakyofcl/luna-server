using System;

namespace LunaServer.DAL.Entities
{
    public class Pharmacist
    {
        public int PharmacistId { get; set;}
        public string PharmacistName { get; set;}
        public int? Gender { get; set;}
        public string PhoneNo { get; set;}
        public string Address { get; set;}
        public int? HospitalId { get; set;}
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        public Hospital Hospital { get; set; }
    }
}