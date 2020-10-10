using System.Collections.Generic;
using Data.Models;
using Services.Services;

namespace Services
{
    public class ServiceProvider
    {
        private static ServiceProvider _instance;
        private static readonly object _lock = new object();

        public ScheduleItemService ScheduleItemService { get; private set; }

        public List<ScheduleItem> repo;

        private ServiceProvider()
        {
            InitializeServices();
            repo = new List<ScheduleItem>();
        }

       
        public static ServiceProvider _getInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ServiceProvider();
                    }
                }
            }

            return _instance;
        }

        private void InitializeServices()
        {
            ScheduleItemService = new ScheduleItemService();
        }




    }
}