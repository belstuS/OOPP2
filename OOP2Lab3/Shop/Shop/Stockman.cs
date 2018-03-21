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
    public class Stockman
    {
        [DataMember]
        public string firstName;
        [DataMember]
        public string secondName;
        [DataMember]
        public string lastName;
        [DataMember]
        public string workExperience;
        [DataMember]
        public string adress;
        public Stockman()
        { }
        public Stockman(string firstName, string secondName, string lastName,
            string workExperience, string adress)
        {
            this.firstName = firstName;
            this.secondName = secondName;
            this.lastName = lastName;
            this.workExperience = workExperience;
            this.adress = adress;
        }
        public override string ToString()
        {
            return "Stockman: \n" + firstName + " " + secondName + " " + lastName + "\nExperience: " +
                this.workExperience + "\nAdress: " + this.adress+"\n";
        }
    }
}
