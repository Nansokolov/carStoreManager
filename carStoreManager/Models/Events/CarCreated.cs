namespace carStoreManager.Models.Events
{
    public class CarCreated : Event
    {
        public required Guid Id { get; init; }
        public required string Name { get; init; }
        public required DateTime CreatedDate { get; init; }
        public override Guid EventId => Id;

    }
}
