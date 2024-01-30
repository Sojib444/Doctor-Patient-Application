using Microsoft.AspNetCore.SignalR;
using SignalRSample.Data;
using SignalRSample.Hubs;
using System.Security.Claims;

namespace Telemedicine.Application.SignalR.Hubs
{
    public class OnlineUserHub : Hub
    {
        public ApplicationDbContext DbContext { get; }

        public OnlineUserHub(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public override Task OnConnectedAsync()
        {
            var userId = Context.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!string.IsNullOrEmpty(userId))
            {
                var user = DbContext.User.FindAsync(userId);

                if (user.Result.AccountType == 1)
                {
                    HubConnections.AddUserConnection(userId, Context.ConnectionId);
                }
            }

            return base.OnConnectedAsync();
        }
    }
}
