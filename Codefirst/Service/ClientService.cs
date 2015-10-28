using Data.InfraStructure;
using Domain.Entity;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ClientService : Service<Client> , IClientService
    {
        static IDataBaseFactory DataFact = new DataBaseFactory();
        static IUnitOfWork unitofW = new UnitOfWork(DataFact);
        public ClientService() : base(unitofW) { }
    }
}
