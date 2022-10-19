using System;
using PubLish.Utils;

namespace PubLish.BuildingBlocks
{
    public abstract class DomainEventBase : IDomainEvent
    {
        public Guid Id { get; }

        public DateTimeOffset OccurredOn { get; }

        public DomainEventBase()
        {
            Id = Guid.NewGuid();
            OccurredOn = DateTimeOffsetProvider.UtcNow;
        }
    }
}
