using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Shop
{
    static class XmlSave
    {
        public static void Serialize<T>(T obj, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                serializer.Serialize(fs, obj);
            }
        }
        public static T Deserialize<T>(string filename)
        {
            T objs;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));
                objs = (T)deserializer.Deserialize(fs);
            }
            return objs;
        }
    }
}
