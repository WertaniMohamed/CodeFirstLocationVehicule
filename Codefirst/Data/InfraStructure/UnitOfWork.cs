using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.InfraStructure
{
    public class UnitOfWork : IUnitOfWork
    {
        MyFinanceContext Mc;
        IDataBaseFactory DataFac;

        //public UnitOfWork(MyFinanceContext mc)
        public UnitOfWork(IDataBaseFactory mc )
        {
            //this.Mc = mc;
            this.DataFac = mc;
            Mc = DataFac.DataContext;
        }
        public void Commit()
        {
            Mc.SaveChanges();
            //throw new NotImplementedException();
        }

        public async Task CommitAsync()
        {
           await Mc.SaveChangesAsync();
        }

        public void Dispose()
        {
            Mc.Dispose();
        }

        public IRepositoryBaseAsync<T> GetRepository<T>() where T : class
        {
            //IRepositoryBaseAsync<T> Repo = new RepositoryBase<T>(Mc);
            IRepositoryBaseAsync<T> Repo = new RepositoryBase<T>(DataFac);
            return Repo; 
        }
    }
}
