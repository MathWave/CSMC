using System;
using System.Runtime.Serialization;
namespace CSMC.Models
{
    [DataContract]
    public class Worker : Person
    {
        [DataMember]
        public string position;
        [DataMember]
        public string photo;
        [DataMember]
        public string email;
    }
}
