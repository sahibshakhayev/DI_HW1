namespace SampleAppPractice.Models
{
    public interface IMessageFactory
    {
        internal IMessage Create(string message);
    }
}