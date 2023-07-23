using LunaServer.Models;
using LunaServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LunaServer.Controllers
{
    [Route("api/Luna/Doctor")]
    public class DoctorController : ControllerBase
    {
        private IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_doctorService.GetDoctor(id));
        }

        [HttpGet("GetHospitalDoctor/{id}")]
        public IActionResult GetHospitalDoctor(int id)
        {
            return Ok(_doctorService.GetHospitalDoctor(id));
        }

        // POST api/<DoctorController>
        [HttpPost]
        public IActionResult Post([FromBody] DoctorModel doctor)
        {
            return Ok(_doctorService.AddDoctor(doctor));
        }

        // PUT api/<DoctorController>
        [HttpPut]
        public IActionResult Put([FromBody]DoctorModel doctor)
        {
            _doctorService.EditDoctor(doctor);
            return Ok();
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_doctorService.RemoveDoctor(id));
        }
    }
}
