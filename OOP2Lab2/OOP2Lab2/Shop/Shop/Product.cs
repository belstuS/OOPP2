using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Shop
{
    [Serializable]
    [DataContract]
    public class Product
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string number { get; set; }
        [DataMember]
        public int mass { get; set; }
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public DateTime date { get; set; }
        [DataMember]
        public Producer producer;
        [DataMember]
        public Stockman stockman;
        public Product(string name, string number, int mass,
            string type, DateTime date, Producer producer, Stockman stockman)
        {
            this.Name = name;
            this.number = number;
            this.mass = mass;
            this.type = type;
            this.date = date;
            this.producer = producer;
            this.stockman = stockman;
        }
        public override string ToString()
        {
            return "Name of product " + this.Name + "\nNumber of product " + this.number +
                "\nMass of product " + this.mass.ToString() + "\nType of product " + this.type +
                "\nDate of product " + this.date.ToString()+"\n"+ this.producer.ToString()+this.stockman.ToString();
        }
    }
}
