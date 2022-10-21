using Microsoft.AspNetCore.Mvc;
using webapp_travel_agency.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webapp_travel_agency.Controllers.Api
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MessageApiController : ControllerBase
    {
        ApplicationDbContext context;
        public MessageApiController()
        {
            context = new ApplicationDbContext();
        }

        [HttpPost]
        public ActionResult SendMessage(Message message)
        {
            context.Message.Add(message);
            context.SaveChanges();

            return Ok();
        }
    }
}
