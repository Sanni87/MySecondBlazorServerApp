using System.Threading.Tasks;
using MySecondBlazorServerApp.Sections.AnotherOne.Hubs.Params.ReceiveMessage;

namespace MySecondBlazorServerApp.Sections.AnotherOne.Hubs.Interfaces;

public interface IAnotherOneHub 
{
    Task ReceiveMessage(ReceiveMessageParams receiveMessageParams);
}