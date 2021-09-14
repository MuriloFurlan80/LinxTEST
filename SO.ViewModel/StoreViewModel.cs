using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.ViewModel
{
    public class StoreViewModel: ViewModelBase
    {
        public string Name { get; set; }
        public ICollection<ProductViewModel> Products { get; set; }
        public UserViewModel User { get; set; }

        public StoreViewModel()
        {
        }

        public StoreViewModel(string id, string name, ICollection<ProductViewModel> products, UserViewModel user) =>
            (Id, Name, Products, User) = (id, name, products, user);
    }
}
