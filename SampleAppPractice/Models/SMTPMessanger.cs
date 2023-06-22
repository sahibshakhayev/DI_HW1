namespace SampleAppPractice.Models
{
    public class SMTPMessanger:IMessanger
    {
        private readonly IClient _client;
        private readonly IMessageFactory _factory;

        public SMTPMessanger(IClient client, IMessageFactory factory)
        {
            _client = client;
            _factory = factory;
        }
        
        public void SendMessage(string message, string user)
        {
            IMessage smtpMessage = _factory.Create(message);
            _client.Send(smtpMessage);
        }
    }
}
