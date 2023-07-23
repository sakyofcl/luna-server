using System;

namespace LunaServer.Models
{
    public class PrescriptionModel
    {
        public int PrescriptionId { get; set; }
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public DateTimeOffset? PrescriptionDate { get; set; }
        public int ReferenceNumber { get; set; }
        public bool? isCollected { get; set; }
    }
}
