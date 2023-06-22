using System.Diagnostics;

namespace SampleAppPractice.Models
{
    public interface IClient
    {
        internal void Send(IMessage Message)
        {
            Debug.WriteLine("Message sent by Client.");
        }
    }
}