using Microsoft.AspNetCore.SignalR;

namespace Telemedicine.Application.SignalR.Hubs
{
    public class ChatHub : Hub
    {
        public static List<string> Message = new List<string>();

        public void SendMesssss(string mesage,string senderEmail, string receiverEmail)
        {
            //essage.Add($"{sender} send {mesage}");

            Clients.All.SendAsync("ReceiveMassage", $"{senderEmail} send a message to {receiverEmail} and Messgae is {mesage}")
                .GetAwaiter().GetResult();
        }
    }
}
