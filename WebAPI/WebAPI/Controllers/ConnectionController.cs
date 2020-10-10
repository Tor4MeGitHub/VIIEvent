using System.Web.Http;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/Connection")]
    public class ConnectionController : ApiController
    {
        [HttpPost]
        [Route("StartConnection")]

        public void AddEvent(string p_id)
        {
           //start connection with signalR
        }
    }
}