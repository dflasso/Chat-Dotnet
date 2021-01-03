using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;


namespace CHAT_DOTNET_CRISATNO_LASSO_VACA.Hubs
{
    
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}