using System;
using System.Collections.Generic;

namespace LunaServer.DAL.Entities
{
    public class Doctor
    {
        public int DoctorId { get; set;}
        public string DoctorName { get; set;}
        public int? Gender { get; set;}
        public string PhoneNo { get; set;}
        public string Qualification { get; set;}
        public string Specialization { get; set;}
        public string Email { get; set;}
        public string Address { get; set;}
        public string DigitalSingnature { get; set;}
        public int? HospitalId { get; set;}
        public bool? isActive { get; set;}
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        public Hospital Hospital { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
    }
}