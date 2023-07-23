using LunaServer.Models;
using LunaServer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LunaServer.Controllers
{
    [Route("api/Luna/Queue")]
    public class QueueController : ControllerBase
    {
        private IQueueService _queueService;
        public QueueController(IQueueService queueService) 
        { 
            _queueService = queueService;
        }
        [HttpPost("AddQueue")]
        public IActionResult AddQueue([FromBody]QueueModel queue)
        {
            return Ok(_queueService.AddQueue(queue));
        }

        [HttpGet("GetAppointments/{ConsultingUnitId}")]
        public IActionResult GetAppointments(int ConsultingUnitId)
        {
            return Ok(_queueService.GetAppointments(ConsultingUnitId));
        }
        [HttpGet("GetAppointment/{AppointmentNumber}")]
        public IActionResult GetAppointment(int AppointmentNumber)
        {
            return Ok(_queueService.GetAppointment(AppointmentNumber));
        }
    }
}
