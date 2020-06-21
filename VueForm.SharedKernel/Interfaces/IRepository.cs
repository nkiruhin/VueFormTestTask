using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VueForm.SharedKernel;

namespace VueForm.SharedKernel.Interfaces
{
    public interface IRepository
    {
        IQueryable<T> GetQuery<T>() where T : BaseEntity;
        Task<T> GetByIdAsync<T>(int id) where T : BaseEntity;
        Task<List<T>> ListAsync<T>() where T : BaseEntity;
        Task<T> AddAsync<T>(T entity) where T : BaseEntity;
        Task UpdateAsync<T>(T entity) where T : BaseEntity;
        Task DeleteAsync<T>(T entity) where T : BaseEntity;
        Task AddRangeAsync<T>(List<T> entitys) where T : BaseEntity;
    }
}