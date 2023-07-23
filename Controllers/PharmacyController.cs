using LunaServer.Models;
using LunaServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LunaServer.Controllers
{
    [Route("api/Luna/Pharmacy")]
    public class PharmacyController : ControllerBase
    {
        private IPharmacyService _pharmacyService;
        public PharmacyController(IPharmacyService pharmacyService)
        {
            _pharmacyService = pharmacyService;
        }

        [HttpGet("GetHospitalPharmacy/{HospitalId}")]
        public IActionResult GetHospitalPharmacy(int HospitalId)
        {
            return Ok(_pharmacyService.GetHospitalPharmacy(HospitalId));
        }
    }
}
