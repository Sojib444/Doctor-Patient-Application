using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;
using Telemedicine.Application.Services.DoctorServices;

namespace Telemedicine.Application.SignalR.Hubs
{
    public class OnlineUserHub : Hub
    {
        private readonly IUserServices _userServices;

        public OnlineUserHub(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public override Task OnConnectedAsync()
        {
            var userId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if(!string.IsNullOrEmpty(userId))
            {
                var user = _userServices.GetUser(userId);

                if(user.Result.AccountType == 1)
                {
                    Clients.Users(HubConnections.OnlineUser()).SendAsync("ReceivedUserConnected",user.Result.Name,user.Result.Email);

                    HubConnections.AddUserConnection(userId, Context.ConnectionId);
                }                                
            }

            return base.OnConnectedAsync();
        }
    }
}
