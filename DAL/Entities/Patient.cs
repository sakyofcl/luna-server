using System;
using System.Collections.Generic;

namespace LunaServer.DAL.Entities
{
    public class Patient
    {
        public int PatientId { get; set;}
        public string PatientName { get; set;}
        public DateTime? Dob { get; set;}
        public int? Gender { get; set;}
        public string PhoneNo { get; set;}
        public string City { get; set;}
        public string Street { get; set;}
        public string BloodGroup { get; set;}
        public bool? isActive { get; set;}
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        public ICollection<Prescription> Prescriptions { get; set;}
        public ICollection<Queue> Queues { get; set;}

    }
}