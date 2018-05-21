using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelWcfPRZWOJ.Model;

namespace LightDbPRZWOJ
{
    public interface ITankRepository
    {
        string CreateTank(Tank tank);
        Tank GetTank(String name);
        List<Tank> GetAllTanks();
    }
}
