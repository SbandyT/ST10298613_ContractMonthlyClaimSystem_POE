using Microsoft.AspNetCore.SignalR;

namespace ST10298613_ContractMonthlyClaimSystem.Hubs
{
    public class NotificationsHub : Hub
    {
        public async Task SendNotification(string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", message);
        }

        public async Task UpdateClaimStatus(List<object> claims)
        {
            await Clients.All.SendAsync("UpdateClaimStatus", claims);
        }
    }
}

