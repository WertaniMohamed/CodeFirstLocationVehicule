using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.InfraStructure
{
    public interface IRepositoryBaseAsync<T> :IRepositoryBase<T> where T : class //type reference
    {
        Task <int> CountAsync();
        Task <List<T>>FindAllAsync(Expression<Func<T, bool>> Where);
        Task <T> FindAsync(Expression<Func<T, bool>> Where);
        Task <List<T>> FindAllAsync();
    }
}
