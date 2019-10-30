using System;
namespace PizzaProject.Domain.Core
{
    public abstract class Entity
    {
        public Entity()
        {
            UId = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
        }

        public string UId { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
