using System;

namespace Domain
{
    public abstract class BaseEntity
    {
        public virtual Guid Id { get; }

        public DateTime CreationTime { get; set; } = DateTime.UtcNow;
    }
}