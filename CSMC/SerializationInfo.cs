using System;
using Xamarin.Forms;
using CSMC.Models;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
namespace CSMC
{
    public static class SerializationInfo
    {

        public static string Path(string line) => Environment.GetFolderPath(Environment.SpecialFolder.Personal) + line + ".json";

        public static void SerializeWorkers(List<Person> list)
        {
            var form = new DataContractJsonSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream(Path("workers"), FileMode.Create))
            {
                form.WriteObject(fs, list);
            }
        }

        public static List<Person> DeseializeWorkers()
        {
            var form = new DataContractJsonSerializer(typeof(List<Person>));
            using (FileStream fs = new FileStream(Path("workers"), FileMode.Open))
            {
                return (List<Person>)form.ReadObject(fs);
            }
        }
    }

}
