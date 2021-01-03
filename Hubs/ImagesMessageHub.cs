using System;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using CHAT_DOTNET_CRISATNO_LASSO_VACA.Models;

namespace CHAT_DOTNET_CRISATNO_LASSO_VACA.Hubs
{
    
    public class ImagesMessageHub : Hub
    {
        public async Task SendImageMessage( ImageMessage file)
        {   
            await Clients.All.SendAsync("ReceiveImageMessage", file);
        }
    }

}