namespace LunaServer.Models
{
    public class HospitalModel
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string RegistrationNo { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string OfficeEmail { get; set; }
        public string HospitalAddress { get; set; }
        public bool? isActive { get; set; }
        public string ProfileImage { get; set; } = "https://image.slidesharecdn.com/b7d6c047-d6cf-45c3-b2a3-44512ca85073-161026075152/85/hospital-profile-pptpptx-2-320.jpg";
    }
}
