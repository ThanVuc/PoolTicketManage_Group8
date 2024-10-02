namespace PoolTicketManagementAPI.DataAccess
{
    public interface IEntityRepository<T>
    {
        void insert(T entity);
        IQueryable<T> GetAllQueryable();
    }
}
