using System;

namespace Store.Domain.Entities
{
    //classe base
    public class Entity
    {
        //contrutors
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}