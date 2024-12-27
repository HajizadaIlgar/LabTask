using EcommerceApi.Core.Entities;

namespace EcommerceApi.BL.Services.Abstracts
{
    public interface IOrderService
    {
        public Task Create(Order entity);
        public Task Delete(int id);
        public IEnumerable<Order> GetAll();
        public Task<Order> GetById(int id);
    }
}
