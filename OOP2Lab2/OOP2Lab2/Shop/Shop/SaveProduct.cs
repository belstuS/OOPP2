using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace Shop
{
    static class SaveProduct
    {
        public static string path = "exmpl.json";
        private static List<Product> ReadFile(List<Product> products, DataContractJsonSerializer jsonFormatter)
        {
            if (!CheckFile())
            {
                using (FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    products = (List<Product>)jsonFormatter.ReadObject(file);
                }
            }
            return products;
        }
        public static List<Product> deserializeProducts()
        {
            List<Product> products = new List<Product>();
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Product>));
            if (File.Exists(path))
            {
                products = ReadFile(products, jsonFormatter);
            }
            return products;
        }
        private static void AppendString(string app)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(app);
            }
        }
        private static void WriteProduct(Product product, DataContractJsonSerializer jsonSerializer)
        {
            using (FileStream file = new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                jsonSerializer.WriteObject(file, product);
            }
        }
        private static void CreateNewFile(Product product, DataContractJsonSerializer jsonSerializer)
        {
            AppendString("[");
            WriteProduct(product, jsonSerializer);
            AppendString("]");
        }
        private static void DeleteSymbol()
        {
            FileStream file = File.OpenWrite(path);
            file.SetLength(file.Length - 3);
            file.Close();
        }
        private static void AddToFile(Product product, DataContractJsonSerializer jsonSerializer)
        {
           DeleteSymbol();
           AppendString(", ");
           WriteProduct(product, jsonSerializer);
           AppendString("]");
        }
        public static bool CheckFile()
        {
            using (FileStream file = File.OpenRead(path))
            {
                if (file.Length == 0)
                    return true;
            }
            return false;
        }
        public static void serializeProduct(Product product)
        {
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Product));
            if (!File.Exists(path) || CheckFile())
            {
                CreateNewFile(product, jsonSerializer);
            }
            else
            {
                AddToFile(product, jsonSerializer);
            }
        }
    }
}
