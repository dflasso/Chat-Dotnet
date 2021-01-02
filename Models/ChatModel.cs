using System.Collections.Generic;
using System;

namespace CHAT_DOTNET_CRISATNO_LASSO_VACA.Models
{
    public class ChatModel 
    {
        public string user{ get; set;}
        public string message{ get; set;}
        public List<MessagesModel> messages{ get; set;}
    }
}