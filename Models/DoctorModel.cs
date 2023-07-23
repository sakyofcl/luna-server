using System;

namespace LunaServer.Models
{
    public class DoctorModel
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
    }
}
