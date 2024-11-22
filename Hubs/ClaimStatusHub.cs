using Microsoft.AspNetCore.SignalR;
namespace ST10298613_ContractMonthlyClaimSystem.Hubs
{
    public class ClaimStatusHub : Hub
    {
        public async Task NotifyStatusChange(string message)
        {
            await Clients.All.SendAsync("ReceiveStatusUpdate", message);
        }
    } 
}
