using SO.Domain.Utils.Exceptions;
using System;

namespace SO.Domain.Entity
{
    public class User : EntityBase
    {
        public string Name { get; private set; }

        public User(string id) : base(id)
        {
        }

        public User(string id, string name) : this(id)
        {
            DomainException.When(string.IsNullOrEmpty(name) || name.Length > 200, "Out of Range name user!");
            Name = name;
        }
    }
}
