using System.Runtime.Serialization;
namespace CSMC.Models
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public string Name;
        [DataMember]
        public string Link;
    }
}
