using SO.Domain.Entity;
using SO.Domain.Repository;
using SO.Domain.Services;
using SO.ViewModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SO.Business
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ICollection<UserViewModel>> Get()
        {
            var users = await _userRepository.GetAsync();
            var vm = new List<UserViewModel>();
            foreach (var user in users)
                vm.Add(new(user.Id, user.Name));
            
            return vm;
        }
    }
}
