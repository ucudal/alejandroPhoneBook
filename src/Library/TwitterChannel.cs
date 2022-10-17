namespace Library
{
    public class TwitterChannel : IMessageChannel
    {
        public void Send(Message message)
        {
            
        }
        public Message GetMessage(Contact sender, Contact receiver)
        {
            return new Message(sender.Name, receiver.Name  );
        }
    }
}