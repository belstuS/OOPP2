using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Shop
{
    [DataContractAttribute]
    [Serializable]
    public class Producer
    {
        [DataMember]
        public string organization;
        [DataMember]
        public string country;
        [DataMember]
        public string telephone;
        [DataMember]
        public string adress;
        public Producer()
        { }
        public Producer(string organization, string country, string telephone,
            string adress)
        {
            this.organization = organization;
            this.country = country;
            this.telephone = telephone;
            this.adress = adress;
        }
        public override string ToString()
        {
            return "Producer:\n" + "Name of organixation: \n" + this.organization +
                "\ncountry: " + this.country + "\nTelephone: " + this.telephone +
                "\nAdress: " + this.adress+"\n";
        }
    }
}
