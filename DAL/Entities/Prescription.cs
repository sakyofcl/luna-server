using System;

namespace LunaServer.DAL.Entities
{
    public class Prescription
    {
        public int PrescriptionId { get; set;}
        public int? DoctorId { get; set;}
        public int? PatientId { get; set;}
        public int? HospitalId { get; set;}
        public int? PharmacyId { get; set;}
        public DateTimeOffset? PrescriptionDate { get; set;}
        public bool? isCollected { get; set;}
        public bool? isForThirdPartyPharmacy { get; set;}
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        public Hospital Hospital { get; set;}
        public Doctor Doctor { get; set;}
        public Patient Patient { get; set;}
        public Pharmacy Pharmacy { get; set;}

    }
}