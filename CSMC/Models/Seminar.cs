using System;
using System.Runtime.Serialization;
namespace CSMC.Models
{
    [DataContract]
    public class Seminar
    {
        [DataMember]
        public string Title;
        [DataMember]
        public string Text;
    }
}
