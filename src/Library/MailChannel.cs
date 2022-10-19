namespace Library
{
    public class MailChannel : IMessageChannel
    {
        public void Send(Message message, Contact receiver)
        {
            // channel= receiver.Email

        }
    }
}