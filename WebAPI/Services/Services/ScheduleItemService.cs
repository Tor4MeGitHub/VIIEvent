using System;
using System.Linq;
using Core.Common;
using Data.Models;
using Services.Interfaces;

namespace Services.Services
{
    public class ScheduleItemService: IScheduleItemService
    {
        private readonly ServiceProvider _serviceProvider = ServiceProvider._getInstance();

        public ServerResponse AddScheduleItem(ScheduleItem p_scheduleItem)
        {
            try
            {
                _serviceProvider.repo.Add(p_scheduleItem);
                return ServerResponse.Ok(p_scheduleItem.Id);
            }
            catch (Exception e)
            {
                return ServerResponse.Fail(e.ToString());
            }
           
        }

        public ServerResponse GetScheduleItem(int p_id)
        {
            try
            {
                var scheduleItem = _serviceProvider.repo.FirstOrDefault(item => item.Id == p_id);
                return ServerResponse.Ok(scheduleItem);
            }
            catch (Exception e)
            {
                return ServerResponse.Fail(e.ToString());
            }
            
        }

        public ServerResponse RemoveScheduleItem(int p_id)
        {
            var itemToRemove = _serviceProvider.repo.Single(item => item.Id == p_id);
            try
            {
                _serviceProvider.repo.Remove(itemToRemove);
                return ServerResponse.Ok(p_id);
            }
            catch (Exception e)
            {
                return ServerResponse.Fail(e.ToString());
            }
          

        }

        public ServerResponse UpdateScheduleItem(ScheduleItem p_scheduleItem)
        {
            var itemToUpdate = _serviceProvider.repo.Single(item => item.Id == p_scheduleItem.Id);
            try
            {
                itemToUpdate.Name = p_scheduleItem.Name;
                itemToUpdate.StartTime = p_scheduleItem.StartTime;
                itemToUpdate.EndTime = p_scheduleItem.EndTime;

                _serviceProvider.repo.Remove(itemToUpdate);
                _serviceProvider.repo.Add(itemToUpdate);

                return ServerResponse.Ok(itemToUpdate);
            }
            catch (Exception)
            {
                Console.WriteLine();
                throw;
            }
        }
    }
}