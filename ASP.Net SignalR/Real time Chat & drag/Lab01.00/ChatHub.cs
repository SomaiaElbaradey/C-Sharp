using Lab01._00.Model;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab01._00
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        chatContext context = new chatContext();    
        public void SendMsg(string name, string msg)
        {
            //broadcast data
            Clients.All.newMsg(name, msg);

            //save to db
            message message = new message()
            {
                name = name,
                message1 = msg,
                date = DateTime.Now
            };
            context.messages.Add(message);
            context.SaveChanges();
        }
    }
}