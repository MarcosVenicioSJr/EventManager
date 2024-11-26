namespace EventManager.Domain.Entities.Enums
{
    public enum EventStatus
    {
        Created = 0,
        Pending = 1,
        AwaitingApproved = 2,
        Canceled = 3,
        Published = 4,
        OnGoing = 5,
        Completed = 6,
        Expired = 7
    }
}
