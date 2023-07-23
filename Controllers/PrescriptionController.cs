using LunaServer.Services;
using LunaServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LunaServer.Controllers
{
    [Route("api/Luna/Prescription")]
    public class PrescriptionController : ControllerBase
    {
        private IPrescriptionService _prescriptionService;
        public PrescriptionController(IPrescriptionService prescriptionService)
        {
            _prescriptionService = prescriptionService;
        }

        [HttpGet("GetPharmacyPrescription/{PharmacyId}")]
        public IActionResult GetPharmacyPrescription(int PharmacyId)
        {
            return Ok(_prescriptionService.GetPharmacyPrescription(PharmacyId));
        }

        [HttpGet("{PrescriptionId}")]
        public IActionResult GetPrescription(int PrescriptionId)
        {
            return Ok(_prescriptionService.GetPrescription(PrescriptionId));
        }

    }
}
