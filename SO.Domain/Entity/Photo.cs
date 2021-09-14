using System;

namespace SO.Domain.Entity
{
    public class Photo : EntityBase
    {
        public Product Product { get; private set; }
        public string ProductId { get; private set; }
        public string Image { get; private set; }

        public Photo(string id) : base(id)
        {
        }

        public Photo(string id, string productId, string image) : this(id)
        {
            ProductId = productId;
            Image = image;
        }
    }
}
