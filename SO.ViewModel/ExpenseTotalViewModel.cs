using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.ViewModel
{
    public class ExpenseTotalViewModel : ViewModelBase
    {
        public decimal Value { get; set; }
        public string StoreId { get; set; }
        public string StoreName { get; set; }
        public string UserId { get; set; }

        public ExpenseTotalViewModel(string id)
        {
            Id = id;
        }
        public ExpenseTotalViewModel(string id, decimal value, string storeId, string storeName, string userId) : this(id)
        {
            Value = value;
            StoreId = storeId;
            StoreName = storeName;
            UserId = userId;
        }

        public ExpenseTotalViewModel(string id, decimal value, string storeId, string storeName) : this(id)
        {
            Value = value;
            StoreId = storeId;
            StoreName = storeName;
        }

        public ExpenseTotalViewModel()
        {
        }
    }
}
