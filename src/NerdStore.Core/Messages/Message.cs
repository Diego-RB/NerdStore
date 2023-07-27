namespace NerdStore.Core.Messages
{
    public abstract class Message
    {
        public string Messagetype { get; protected set; }
        public Guid AggregateId { get; protected set; }

        public Message()
        {
            Messagetype = GetType().Name;
        }
    }
}
