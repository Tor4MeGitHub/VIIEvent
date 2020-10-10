using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Core.Common;
using Data.Models;
using Services;

namespace WebAPI.Controllers
{
    [RoutePrefix("api/VIIEvents")]
    public class ScheduleItemController : ApiController
    {
        private ServiceProvider _serviceProvider = ServiceProvider._getInstance();

        [HttpPost]
        [Route("AddEvent")]

        public ServerResponse AddEvent(ScheduleItem p_scheduleItem)
        {
            return _serviceProvider.ScheduleItemService.AddScheduleItem(p_scheduleItem);
        }

        [HttpPost]
        [Route("GetEvent")]

        public ServerResponse GetEvent(ScheduleItem p_scheduleItem)
        {
            return _serviceProvider.ScheduleItemService.GetScheduleItem(p_scheduleItem.Id);
        }

        [HttpPost]
        [Route("RemoveEvent")]

        public ServerResponse RemoveEvent(ScheduleItem p_scheduleItem)
        {
            return _serviceProvider.ScheduleItemService.RemoveScheduleItem(p_scheduleItem.Id);
        }

        [HttpPost]
        [Route("UpdateEvent")]

        public ServerResponse UpdateEvent(ScheduleItem p_scheduleItem)
        {
            return _serviceProvider.ScheduleItemService.AddScheduleItem(p_scheduleItem);
        }


        //function for signalR. Need implementation
        public ServerResponse ReturnEvent(ScheduleItem p_scheduleItem)
        {
            return _serviceProvider.ScheduleItemService.AddScheduleItem(p_scheduleItem);
        }

    }
}