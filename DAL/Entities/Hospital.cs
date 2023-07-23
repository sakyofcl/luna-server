using System;
using System.Collections.Generic;

namespace LunaServer.DAL.Entities
{
    public class Hospital
    {
        public int HospitalId { get; set;}
        public string HospitalName { get; set;}
        public string RegistrationNo { get; set;}
        public string Description { get; set;}
        public string PhoneNumber { get; set;}
        public string OfficeEmail { get; set;}
        public string HospitalAddress { get; set;}
        public bool? isActive { get; set;}
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        public ICollection<Pharmacy> Pharmacies { get; set; }
        public ICollection<Pharmacist> Pharmacists { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
        public ICollection<ConsultingUnit> ConsultingUnits { get; set; }
    }
}