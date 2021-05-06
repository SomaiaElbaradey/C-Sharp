using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab01._00
{
    [HubName("drag")]
    public class ChatHub : Hub
    {
        public void SendCoord(double x, double y)
        {
            //broadcast data
            Clients.All.newCoord(x, y);
        }
    }
}