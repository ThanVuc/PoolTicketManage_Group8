using Microsoft.EntityFrameworkCore;
using PoolTicketManagementAPI.Data;

namespace PoolTicketManagementAPI.DataAccess
{
    public class EntityRepository<T> : IEntityRepository<T> where T : class, new()
    {
        private readonly AppDbContext _context;
        private DbSet<T> _dbSet;

        public EntityRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public IQueryable<T> GetAllQueryable()
        {
            return _dbSet;
        }

        public void insert(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
    }
}
