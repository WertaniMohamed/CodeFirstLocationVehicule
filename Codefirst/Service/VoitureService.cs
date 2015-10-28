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
    class VoitureService:Service<Voiture> , IVoitureService
    {
        static IDataBaseFactory DataFact = new DataBaseFactory();
        static IUnitOfWork unitofW = new UnitOfWork(DataFact);
        public VoitureService() :base(unitofW) { }
    }
}
