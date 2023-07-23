using LunaServer.DAL.Repository;

namespace LunaServer.DAL.Interface{
    public interface IUnitOfWork{
        public UserRepository User {get;}
        public HospitalRepository Hospital { get; }
        public ConsultingUnitRepository ConsultingUnit { get; }
        public QueueRepository Queue { get; }
        public PharmacyRepository Pharmacy { get; }
        public PrescriptionRepository Prescription { get; }
        public DoctorRepository Doctor { get; }
    }
}