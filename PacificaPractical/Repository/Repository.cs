using Microsoft.EntityFrameworkCore;
using PacificaPractical.Database;

namespace PacificaPractical.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private ProductDbContext _context = null;

        private DbSet<T> table = null;

        public Repository()
        {
            this._context = new ProductDbContext();
            table = _context.Set<T>();
        }

        public Repository(ProductDbContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        void IRepository<T>.Delete(object id)
        {
            T existing = table.Find(id);
            table.Attach(existing);
            _context.Entry(existing).State = EntityState.Modified;
        }

        IEnumerable<T> IRepository<T>.GetAll()
        {
            return table?.ToList();
        }

        T IRepository<T>.GetById(object id)
        {
            return table.Find(id);
        }

        void IRepository<T>.Insert(T obj)
        {
            table.Add(obj);
        }

        void IRepository<T>.Save()
        {
            _context.SaveChanges();
        }

        void IRepository<T>.Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
    }
}
