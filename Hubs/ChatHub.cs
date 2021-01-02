using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;


namespace CHAT_DOTNET_CRISATNO_LASSO_VACA.Hubs
{
    //La clase Hub administra conexiones, grupos y mensajería.
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}