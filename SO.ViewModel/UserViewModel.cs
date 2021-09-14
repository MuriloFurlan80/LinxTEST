using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.ViewModel
{
    public class UserViewModel : ViewModelBase
    {
        public string Name { get; set; }
        public UserViewModel()
        {
        }

        public UserViewModel(string id, string name) => 
            (Id, Name) = (id, name);
    }
}
