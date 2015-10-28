using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.InfraStructure
{
    public class RepositoryBase<T> : IRepositoryBaseAsync<T> where T : class
    {

        MyFinanceContext Mc;
        IDbSet<T> DbSet;

        //public RepositoryBase(MyFinanceContext m)//pour  instancier plusieur fois
        IDataBaseFactory DataFa;
        public RepositoryBase(IDataBaseFactory m)
        {
            DataFa = m;
            //DbSet = Mc.Set<T>();
            DbSet = DataContext.Set<T>();

        }

        public MyFinanceContext DataContext { get { return Mc = DataFa.DataContext; } }

        public void Add(T t)
        {
            //throw new NotImplementedException();
            DbSet.Add(t);
        }

        public async Task<int> CountAsync()
        {
            return await DbSet.CountAsync();
           
        }

        public void Delete(Expression<Func<T, bool>> Where)
        {
            IEnumerable<T> d = DbSet.Where(Where);
            foreach (var item in d)
            {
                DbSet.Remove(item);
            }
        }

        public void Delete(T t)
        {

            //DbSet.Remove(t);
            Mc.Entry(t).State = EntityState.Deleted;

        }

        public async Task<List<T>> FindAllAsync()
        {
            return await DbSet.ToListAsync();
        }

        public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> Where)
        {
            return await DbSet.Where(Where).ToListAsync();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> Where)
        {
            return await DbSet.FirstOrDefaultAsync(Where);
        }

        public T Get(Expression<Func<T, bool>> Where)
        {
           // return DbSet.Where(Where).FirstOrDefault();
            
            return DbSet.FirstOrDefault(Where);
        }

        public T GetbyId(string Name)
        {
            
           return DbSet.Find(Name);
        }

        public T GetbyId(long Id)
        {
            return DbSet.Find(Id);
        }

        public IEnumerable<T> GetMany(Expression<Func<T, bool>> Where = null, Expression<Func<T, bool>> orderby = null)
        {


            IQueryable<T> d = DbSet;//plus rapide que IEnumerable
            if (Where != null)
            {
                d = d.Where(Where);
            }

            if (orderby != null)
            {
                d = d.OrderBy(orderby);
            }

            return d;

        }

        public void Update(T t)
        {
            // throw new NotImplementedException();
            DbSet.Attach(t);//optionnel
            Mc.Entry(t).State = EntityState.Modified;// pour changer l'etat de l'objet       
         }
        }
}
