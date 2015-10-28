using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.InfraStructure
{
    public interface IUnitOfWork:IDisposable
    {

        IRepositoryBaseAsync<T> GetRepository<T>() where T : class;

        void Commit();


        Task CommitAsync();
        
    }
}
