using LunaServer.DAL.Entities;
using LunaServer.Models;
using LunaServer.Services;
using LunaServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LunaServer.Controllers
{
    [Route("api/Luna/ConsultingUnit")]
    public class ConsultingUnitController : ControllerBase
    {
        private IConsultingUnitService _consultingUnitService;

        public ConsultingUnitController(IConsultingUnitService consultingUnitService)
        {
            _consultingUnitService = consultingUnitService;
        }
        [HttpGet("Hospital/{HospitalId}")]
        public IActionResult GetHospitalUnits(int HospitalId)
        {
            return Ok(_consultingUnitService.GetHospitalUnits(HospitalId));
        }

        [HttpGet("Patient/{PatientId}")]
        public IActionResult GetHospitalUnitsForPatient(int PatientId)
        {
            return Ok(_consultingUnitService.GetHospitalUnitsForPatient(PatientId));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_consultingUnitService.GetConsultingUnit(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] ConsultingUnitModel consultingUnit)
        {
            return Ok(_consultingUnitService.AddConsultingUnit(consultingUnit));
        }

        [HttpPut]
        public IActionResult Put([FromBody] ConsultingUnitModel consultingUnit)
        {
            _consultingUnitService.EditConsultingUnit(consultingUnit);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_consultingUnitService.RemoveConsultingUnit(id));
        }
    }
}
