using MyFinance.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.InfraStructure
{
    public class DataBaseFactory : Disposable, IDataBaseFactory
    {
        MyFinanceContext MC;
        public DataBaseFactory()
        {
            MC = new MyFinanceContext();
        }
        public MyFinanceContext DataContext
        {
            get
            {
                return MC;
            }
        }

        protected override void DisposeCore()//supprimer l'objet si instantier
        {
            if (DataContext != null)
            {
                DataContext.Dispose();

            }
        }
    }
}
