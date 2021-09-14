using SO.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SO.Domain.Services
{
    public interface IUserService : IService
    {
        Task<ICollection<UserViewModel>> Get();
    }
}
