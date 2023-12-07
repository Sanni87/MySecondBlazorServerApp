using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Hosting;
using MySecondBlazorServerApp.Sections.AnotherOne.Hubs;
using MySecondBlazorServerApp.Sections.AnotherOne.Hubs.Interfaces;
using MySecondBlazorServerApp.Sections.AnotherOne.Hubs.Params.ReceiveMessage;

public class AnotherOneWorker : BackgroundService
{
    private readonly IHubContext<AnotherOneHub, IAnotherOneHub> _anotherOneHub;
    private readonly Random _random;
    public AnotherOneWorker(IHubContext<AnotherOneHub, IAnotherOneHub> anotherOneHub)
    {
        _anotherOneHub = anotherOneHub;
        _random = new Random();
    }
    
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var randSeconds = _random.Next(1, 3);
            await Task.Delay(randSeconds * 1000, stoppingToken);

            var args = new ReceiveMessageParams
            {
                Age = randSeconds,
                Name = randSeconds % 2 == 0 ? "Paco" : "Charo",
                IsCool = randSeconds % 3 > 1 ? true : false
            };

            await _anotherOneHub.Clients.All.ReceiveMessage(args);
        }
    }
}