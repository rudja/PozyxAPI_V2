using Microsoft.AspNet.SignalR;
using PozyxAPI_V2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace PozyxAPI_V2.Controllers
{
    public class MyEndPoint : Hub
    {


        public void Send()
        {
            //There will be a script who will call this method each time the position will change
            Localization position = new Localization();
            position.x = 2;
            position.y = 10;
            Clients.All.sendNewPosition(position);
        }


        //protected override Task OnConnected(IRequest request, string connectionId)
        //{
        //    return Connection.Broadcast("Connection " + connectionId + " connected");
        //}

        //protected override Task OnReconnected(IRequest request, string connectionId)
        //{
        //    return Connection.Broadcast("Client " + connectionId + " re-connected");
        //}

        //protected override Task OnReceived(IRequest request, string connectionId, string data)
        //{
        //    return Connection.Broadcast("Connection " + connectionId + " sent " + data);
        //}

        /*protected override Task OnDisconnected(IRequest request, string connectionId)
        {
            return Connection.Broadcast("Connection " + connectionId + " disconncted");
        }*/
    }
}