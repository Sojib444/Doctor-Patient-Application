using Microsoft.AspNetCore.SignalR;

namespace Telemedicine.Application.SignalR.Hubs
{
    public class UserHub : Hub
    {
        public static int TotalViews {  get; set; }
        public static int TotalTab {  get; set; }

        public override Task OnConnectedAsync()
        {
            TotalTab++;
            Clients.All.SendAsync("TotalCount",TotalTab).GetAwaiter().GetResult();
            return base.OnConnectedAsync();
        }

        public override Task OnDisconnectedAsync(Exception exception)
        {
            TotalTab--;
            Clients.All.SendAsync("TotalCount", TotalTab).GetAwaiter().GetResult();
            return base.OnDisconnectedAsync(exception);
        }

        public async Task NewWindowLoading()
        {
            TotalViews++;

            await Clients.All.SendAsync("UpateCount", TotalViews);
        }

    }
}
