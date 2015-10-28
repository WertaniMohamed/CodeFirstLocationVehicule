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
    class ContratService:Service<Contrat> , IContratService
    {
        static IDataBaseFactory DataFac = new DataBaseFactory();
        static IUnitOfWork unitofw = new UnitOfWork(DataFac);

        public ContratService() : base(unitofw) { }
    }
}
