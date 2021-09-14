using System;

namespace SO.ViewModel
{
    public class ProductViewModel : ViewModelBase
    {
        public ProductViewModel(string id, string name, decimal price, string description, int quantity, string photo)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
            Quantity = quantity;
            Photo = photo;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public string Photo { get; set; }
    }
}
