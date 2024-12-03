using Microsoft.AspNetCore.SignalR;

namespace chatBot.Hubs;

public class ManagerHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);

        var botResponse = GetBotResponse(message);
        await Clients.All.SendAsync("ReceiveMessage", "ChatBot", botResponse);
    }

    private string GetBotResponse(string message)
    {
        if (message.Contains("hello", StringComparison.OrdinalIgnoreCase))
        {
            return "Hi there! How can I help you today?";
        }
        else if (message.Contains("help", StringComparison.OrdinalIgnoreCase))
        {
            return "Sure! Ask me anything about our services.";
        }
        else
        {
            return "I'm not sure I understand that. Can you rephrase?";
        }
    }
}