using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.InfraStructure
{
    public interface IRepositoryBase<T>where T: class //type reference
    {
        void Add(T t);
        void Delete(T t);
        void Delete(Expression<Func<T,bool>> Where);//delete avec condition de nom where
        T Get(Expression<Func<T, bool>> Where);//retour un champ avec condition
        T GetbyId(long Id);
        T GetbyId(string Name);
        void Update(T t);
        IEnumerable<T>GetMany(Expression<Func<T, bool>> Where = null, Expression<Func<T, bool>> orderby=null);



    }
}
