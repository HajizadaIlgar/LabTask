using EcommerceApi.Core.Entities;
using EcommerceApi.Core.IRepositories;
using EcommerceApi.DAL.DAL;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApi.Core.Repositories;

public class GenericRepositories<T> : IGenericRepositories<T> where T : BaseEntity, new()
{
    private readonly ECommerceDbContext _context;
    public GenericRepositories(ECommerceDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async void Delete(int id)
    {
        _context.Remove(id);
    }

    public IQueryable<T> GetAll(bool isTracking, params string[] includes)
    {
        var query = _context.Set<T>().AsQueryable();
        if (!isTracking)
        {
            query = query.AsNoTracking();
        }
        if (includes.Length > 0)
        {
            foreach (string item in includes)
            {
                query = query.Include(item);
            }
        }
        return query;
    }

    public T GetById(int id)
    {
        throw new NotImplementedException();
    }
}