using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using ModelWcfPRZWOJ.Model;

namespace LightDbPRZWOJ
{
    public class TankRepository : ITankRepository
    {
        static readonly string _dbPath = @"C:\tmp\tanks";
        
        public Tank GetTank(string name)
        {
            using (var db = new LiteDatabase(_dbPath))
            {
                var repo = db.GetCollection<TankDb>("tank");
                TankDb tank = repo.Find(Query.EQ("ModelName", name)).First();

                return Map(tank);
            }
        }

        public string CreateTank(Tank tank)
        {
            using(var db = new LiteDatabase(_dbPath))
            {
                var repo = db.GetCollection<TankDb>("tank");
                if (repo.FindById(tank.Id) == null)
                {
                    repo.Insert(InverseMap(tank));
                    return "dodano";
                }
                else
                {
                    return "juz istnieje";
                }
            }
        }


        private Tank Map(TankDb model)
        {
            return new Tank(id : model.Id, power : model.Power, shield : model.Shield, modelName : model.ModelName);
        }

        private TankDb InverseMap(Tank model)
        {
            return new TankDb(id : model.Id, power : model.Power, shield : model.Shield, modelName : model.ModelName);
        }

        public List<Tank> GetAllTanks()
        {
            using (var db = new LiteDatabase(_dbPath))
            {
                var repo = db.GetCollection<TankDb>("tank");
                var tanks = repo.FindAll();

                return tanks.Select(t => Map(t)).ToList();
            }
        }
    }


}
