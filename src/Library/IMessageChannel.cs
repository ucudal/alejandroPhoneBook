namespace Library
{
    public interface IMessageChannel
    {
        void Send(Message message);
        Message GetMessage(Contact sender, Contact receiver);
    }
}