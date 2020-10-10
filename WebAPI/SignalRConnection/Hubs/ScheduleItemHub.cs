using Microsoft.AspNet.SignalR;

namespace SignalRConnection.Hubs
{
    public class ScheduleItemHub : Hub
    {
        public void Send(string name, string message)
        {
            Clients.All.addMessage(name, message);
        }
    }
}