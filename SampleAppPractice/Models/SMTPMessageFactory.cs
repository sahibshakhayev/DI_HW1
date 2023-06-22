namespace SampleAppPractice.Models
{
    public class SMTPMessageFactory : IMessageFactory
    {

        internal IMessage Create(string message)
        {
            return new SmtpMessage() { Body = message };
        }

        IMessage IMessageFactory.Create(string message)
        {
            throw new NotImplementedException();
        }
    }
}
