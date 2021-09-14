using SO.Domain.Repository;
using SO.Domain.Services;
using SO.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SO.Business
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _repository;
        private readonly IUserRepository _userRepository;
        private readonly IProductRepository _productRepository;
        public StoreService(IStoreRepository repository, IUserRepository userRepository, IProductRepository productRepository)
        {
            _repository = repository;
            _userRepository = userRepository;
            _productRepository = productRepository;
        }

        public async Task<StoreViewModel> Get(string userId)
        {
            var idRef = userId.ToString();
            var user = await _userRepository.FindAsync(x => x.Id == idRef);
            var store = await _repository.FirstAsync();
            var products = await _productRepository.GetProductsByStore(store.Id);


            var productsVm = new List<ProductViewModel>();

            if (products is not null)
                foreach (var product in products)
                    productsVm.Add(new ProductViewModel(product.Id, product.Name, product.Price, product.Description, product.Quantity, product.Photo?.Image));

            var userVm = new UserViewModel();

            if (user is not null)
                userVm = new UserViewModel(user.Id, user.Name);

            StoreViewModel storeVm = new(store?.Id, store?.Name, productsVm, userVm);

            return storeVm;
        }
    }
}
