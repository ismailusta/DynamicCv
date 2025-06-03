using DynamicCv.Models.Entity;
using System.Linq.Expressions;

namespace DynamicCv.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        CvContext db = new CvContext();
        public List<T> List()
        {
            return db.Set<T>().ToList();
        }
        public void TAdd(T p) 
        {
            db.Set<T>().Add(p);
            db.SaveChanges();
        }
        public void TRemove(T p)
        {
            db.Set<T>().Remove(p);
            db.SaveChanges();
        }
        public T TGet(int id) 
        {
            return db.Set<T>().Find(id);
        }
        public T Find(Expression<Func<T,bool>> where) 
        {
            return db.Set<T>().FirstOrDefault(where);
        }
        public void TUpdate(T p) 
        {
            db.SaveChanges();
        }

    }
}
