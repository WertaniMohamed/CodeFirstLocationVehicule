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
    public class AgenceService : Service<Agence>, IAgenceService
    {
        static IDataBaseFactory DataFac =new DataBaseFactory();
        static IUnitOfWork unitofw = new UnitOfWork(DataFac);


        public AgenceService():base(unitofw)
        {
        }

        public List<Agence> GetAgenceByAdresse(string adresse)
        {
            return unitofw.GetRepository<Agence>().GetMany(p=>p.Adresse== adresse).ToList();
        }
    }
}
