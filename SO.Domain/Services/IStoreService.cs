using SO.ViewModel;
using System;
using System.Threading.Tasks;

namespace SO.Domain.Services
{
    public interface IStoreService : IService
    {
        Task<StoreViewModel> Get(string userId);
    }
}
