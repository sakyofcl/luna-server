using Microsoft.AspNetCore.Mvc;
using LunaServer.Services.Interfaces;

namespace LunaServer.Controllers{
    
    [Route("api/Luna/Test")]
    public class TestController : ControllerBase{
        private ITestService _testService;
        public TestController(ITestService testService){
            _testService = testService;
        }

        [HttpGet]
        public string GreetingMessage(){
            return _testService.greetingMessage();
        }
    }

}
