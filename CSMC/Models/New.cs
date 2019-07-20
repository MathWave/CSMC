using System;
using System.Runtime.Serialization;
namespace CSMC.Models
{
    [DataContract]
    public class New
    {
        [DataMember]
        public string Text;
        [DataMember]
        public string Link;
        [DataMember]
        public string Image;
    }
}
