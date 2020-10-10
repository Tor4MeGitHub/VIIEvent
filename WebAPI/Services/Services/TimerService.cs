using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Core.Common;
using Data.Models;

namespace Services.Services
{
    public class TimerService
    {
        private static readonly ServiceProvider _serviceProvider = ServiceProvider._getInstance();
        public List<ScheduleItem> repo = _serviceProvider.repo;

        static TimerCallback tm;
        
        Timer _timer = new Timer(tm, 0, 0, GlobalParameters.TimeService);

        public TimerService()
        {
            tm = new TimerCallback(CheckEvents);
        }

        public void CheckEvents(object obj)
        {
            if (!repo.Any()) return;
          foreach (var item in repo)
            {
                if (item.StartTime <= DateTime.Now)
                {
                    //Call SignalR service and controller
                }
            }
        }
    }
}