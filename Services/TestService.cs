using LunaServer.DAL.Interface;
using LunaServer.Services.Interfaces;

namespace LunaServer.Services{
    public class TestService : ITestService{
        private IUnitOfWork _uow;
        public TestService(IUnitOfWork uow){ 
            _uow = uow;
        }
        public string greetingMessage(){
            var x = _uow.User.GetAll();
            return "Welcome to my api";
        }
    }
}