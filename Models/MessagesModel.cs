using System;
using Microsoft.AspNetCore.Http;

namespace CHAT_DOTNET_CRISATNO_LASSO_VACA.Models
{
    public class MessagesModel
    {
        public string Msg{ get; set;}
        public IFormFile FileAttach{ get; set;}
    }
}