using Microsoft.AspNetCore.SignalR;

namespace Telemedicine.Application.SignalR.Hubs
{
    public class UserHub : Hub
    {
        public static int TotalViews {  get; set; }

        public UserHub()
        {
            
        }

        public async Task NewWindowLoading()
        {
            TotalViews++;

            await Clients.All.SendAsync("UpateCount", TotalViews);
        }

    }
}
