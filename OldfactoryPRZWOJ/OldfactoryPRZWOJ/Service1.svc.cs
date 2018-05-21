using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ModelWcfPRZWOJ.Model;
using LightDbPRZWOJ;

namespace OldfactoryPRZWOJ
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IService1
    {
        private readonly ITankRepository _repository = new TankRepository();

        public string CreateTank(Tank tank)
        {
            return _repository.CreateTank(tank);
        }

        public List<Tank> GetAllTanks()
        {
            return _repository.GetAllTanks();
        }

        public Tank GetTank(string name)
        {
            return _repository.GetTank(name);
        }

    }

}
