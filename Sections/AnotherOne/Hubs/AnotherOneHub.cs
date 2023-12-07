using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using MySecondBlazorServerApp.Sections.AnotherOne.Hubs.Interfaces;
namespace MySecondBlazorServerApp.Sections.AnotherOne.Hubs;

public class AnotherOneHub : Hub<IAnotherOneHub>
{
    public override Task OnConnectedAsync()
    {
        return base.OnConnectedAsync();
    }

    public override Task OnDisconnectedAsync(Exception exception)
    {
        return base.OnDisconnectedAsync(exception);
    }
}