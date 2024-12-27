using EcommerceApi.Core.Entities;

namespace EcommerceApi.Core.IRepositories
{
    public interface IGenericRepositories<T> where T : BaseEntity, new()
    {
        IQueryable<T> GetAll(bool isTracking, params string[] includes);
        public Task AddAsync(T entity);
        public void Delete(int id);
        T GetById(int id);
    }

}
