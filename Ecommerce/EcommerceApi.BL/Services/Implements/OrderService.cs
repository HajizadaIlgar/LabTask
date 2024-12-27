using EcommerceApi.BL.Services.Abstracts;
using EcommerceApi.Core.Entities;
using EcommerceApi.Core.IRepositories;

namespace EcommerceApi.BL.Services.Implements
{
    public class OrderService(IGenericRepositories<Order> _repo) : IOrderService
    {
        public Task Create(Order entity)
        {
            var data = _repo.AddAsync(entity);
            return data;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
