using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Shop
{
    [Serializable]
    [XmlType("product")]
    [DataContract]
    public class Product
    {
        [DataMember]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Too small name")]
        [XmlElement(ElementName ="name")]
        public string Name { get; set; }
        [DataMember]
        [XmlElement(ElementName = "number")]
        public string number { get; set; }
        [DataMember]
        [XmlElement(ElementName = "mass")]
        public int mass { get; set; }
        [DataMember]
        [XmlElement(ElementName = "type")]
        public string type { get; set; }
        [DataMember]
        [XmlElement(ElementName = "price")]
        [Required]
        [Range(0.99, 999.99, ErrorMessage ="Incorrect mass")]
        public double price { get; set; }
        [DataMember]
        [XmlElement(ElementName = "date")]
        public DateTime date { get; set; }
        [DataMember]
        [XmlElement(ElementName = "producer")]
        public Producer producer;
        [DataMember]
        [XmlElement(ElementName = "stockman")]
        public Stockman stockman;
        public Product()
        {

        }
        public Product(string name, string number, int mass,
            string type, double price, Producer producer, Stockman stockman, DateTime date)
        {
            this.Name = name;
            this.number = number;
            this.mass = mass;
            this.type = type;
            this.price = price;
            this.producer = producer;
            this.stockman = stockman;
            this.date = date;
        }
        public override string ToString()
        {
            return "Name of product " + this.Name + "\nNumber of product " + this.number +
                "\nMass of product " + this.mass.ToString() + "\nType of product " + this.type +
                "\nDate of product " +
                this.date.ToString() +
                "\nPrice of product: " +
                this.price.ToString()+"\n" + this.producer.ToString()+this.stockman.ToString()+"\n";
        }
    }
}
