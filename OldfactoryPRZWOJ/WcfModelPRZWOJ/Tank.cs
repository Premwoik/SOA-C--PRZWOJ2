using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Runtime.Serialization;

namespace OldfactoryPRZWOJ.Model
{
    [DataContract]
    public class Tank
    {
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