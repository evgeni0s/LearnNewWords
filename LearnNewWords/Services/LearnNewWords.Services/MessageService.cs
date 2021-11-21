using LearnNewWords.Services.Interfaces;

namespace LearnNewWords.Services
{
    public class MessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Hello from the Message Service";
        }
    }
}
