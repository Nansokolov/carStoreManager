namespace carStoreManager.Models.Events
{
    public class CarUpdated : Event
    {
        public required Guid Id { get; init; }
        public required string Name { get; init; }
        public override Guid EventId => Id;

    }
}
