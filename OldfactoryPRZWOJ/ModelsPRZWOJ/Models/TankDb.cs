using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightDbPRZWOJ
{
    public class TankDb
    {
        public TankDb(int id, int power, int shield, string modelName)
        {
            Id = id;
            Power = power;
            Shield = shield;
            ModelName = modelName;
        }

        public int Id { get; set; }
        public int Power { get; set; }
        public int Shield { get; set; }
        public string ModelName { get; set; }
    }
}
