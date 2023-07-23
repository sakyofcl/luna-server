using LunaServer.DAL.Interface;
using LunaServer.DAL.Repository;
using LunaServer.DAL.DBContext;

namespace LunaServer.DAL.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private UserRepository _user;
        private HospitalRepository _hospital;
        private ConsultingUnitRepository _consultingUnit;
        private QueueRepository _queueRepository;
        private PharmacyRepository _pharmacyRepository;
        private PrescriptionRepository _prescriptionRepository;
        private DoctorRepository _doctorRepository;
        private readonly LunaDBContext _context;
        
        public UnitOfWork(LunaDBContext context){
            _context = context;
        }
        public UserRepository User {
            get {return _user = new UserRepository(_context);}
        }
        public HospitalRepository Hospital
        {
            get {return _hospital = new HospitalRepository(_context);}
        }
        public ConsultingUnitRepository ConsultingUnit
        {
            get { return _consultingUnit = new ConsultingUnitRepository(_context); }
        }
        public QueueRepository Queue
        {
            get { return _queueRepository = new QueueRepository(_context); }
        }
        public PharmacyRepository Pharmacy
        {
            get { return _pharmacyRepository = new PharmacyRepository(_context); }
        }
        public PrescriptionRepository Prescription
        {
            get { return _prescriptionRepository = new PrescriptionRepository(_context); }
        }
        public DoctorRepository Doctor
        {
            get { return _doctorRepository = new DoctorRepository(_context); }
        }
    }
}
