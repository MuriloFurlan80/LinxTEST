using SO.Domain.Utils.Exceptions;
using System;
using System.Collections.Generic;

namespace SO.Domain.Entity
{
    public class Store : EntityBase
    {
        public string Name { get; private set; }
        public ExpenseTotal ExpenseTotal { get; set; }
        public ICollection<Product> Products { get; private set; }

        public Store(string id) : base(id)
        {
        }

        public Store(string id, string name, ICollection<Product> products) : this(id, name)
        {
            Products = products;
        }
        public Store(string id, string name) : this(id)
        {
            DomainException.When(string.IsNullOrEmpty(name) || name.Length > 200, "Name is not valid! Add a name valid.");
            Name = name;
        }
    }
}
