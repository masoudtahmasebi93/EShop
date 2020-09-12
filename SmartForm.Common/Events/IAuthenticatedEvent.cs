using System;

namespace EShop.Common.Events
{
    public interface IAuthenticatedEvent : IEvent
    {
        Guid? UserId { get; }
    }
}