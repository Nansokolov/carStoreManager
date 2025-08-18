namespace carStoreManager.Models.Events
{
    public abstract class Event
    {
        public abstract Guid EventId { get; }
        public DateTime CreatedAtUtc { get; set; }
    }
}
