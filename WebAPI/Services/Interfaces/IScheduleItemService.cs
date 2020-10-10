using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Common;
using Data.Models;

namespace Services.Interfaces
{
    public interface IScheduleItemService
    {
        ServerResponse AddScheduleItem(ScheduleItem p_scheduleItem);

        ServerResponse GetScheduleItem(int p_id);

        ServerResponse RemoveScheduleItem(int p_id);

        ServerResponse UpdateScheduleItem(ScheduleItem p_scheduleItem);
    }
}
