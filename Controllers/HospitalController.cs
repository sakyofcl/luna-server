using LunaServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LunaServer.Controllers
{
    [Route("api/Luna/Hospital")]
    public class HospitalController : ControllerBase
    {
        private IHospitalService _hospitalService;
        public HospitalController(IHospitalService hospitalService)
        {
            _hospitalService = hospitalService;
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_hospitalService.GetAll());
        }

        [HttpGet("{HospitalId}")]
        public IActionResult Get(int HospitalId)
        {
            return Ok(_hospitalService.Get(HospitalId));
        }
    }
}
