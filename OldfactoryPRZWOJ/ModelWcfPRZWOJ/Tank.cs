using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace ModelWcfPRZWOJ.Model
{
    [DataContract]
    public class Tank
    {
        public Tank(int id, int power, int shield, string modelName)
        {
            Id = id;
            Power = power;
            Shield = shield;
            ModelName = modelName;
        }

        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Power { get; set; }
        [DataMember]
        public int Shield { get; set; }
        [DataMember]
        public string ModelName { get; set; }
    }
}