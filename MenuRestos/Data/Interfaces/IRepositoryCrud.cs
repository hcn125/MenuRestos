using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MenuRestos.Data.Interfaces
{
    public interface IRepositoryCrud<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(params string[] includes);
        Task<int> SaveChangesAsync();
        public DbContext Context { get; }
    }
}
