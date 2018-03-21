using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Shop
{
    static class ProductSort
    {
        public static IEnumerable<Product> SearchByName(IEnumerable<Product> products, string searchString)
        {
            return products.Where(p => p.Name.Equals(searchString));
        }
        public static IEnumerable<Product> SearchByType(IEnumerable<Product> products, string searchString)
        {
            return products.Where(p => p.type.Equals(searchString));
        }
        public static IEnumerable<Product> SearchByPrice(IEnumerable<Product> products, int min)
        {
            return products.Where(p => p.price> min);
        }
        public static IEnumerable<Product> SortByName(IEnumerable<Product> products)
        {
            IEnumerable<Product> sortedList = from product in products
                                              orderby product.Name
                                              select product;
            return sortedList;
        }
        public static IEnumerable<Product> SortByDate(IEnumerable<Product> products)
        {
            IEnumerable<Product> sortedList = from product in products
                                              orderby product.date
                                              select product;
            return sortedList;
        }
        public static IEnumerable<Product> SortByRegex(IEnumerable<Product> products, Regex regex)
        {
            IEnumerable<Product> sortedList = from product in products
                                              where regex.IsMatch(product.Name)
                                              select product;
            return sortedList;
        }
        public static IEnumerable<Product> SortByPrice(IEnumerable<Product> products)
        {
            IEnumerable<Product> sortedList = from product in products
                                              orderby product.price
                                              select product;
            return sortedList;
        }
    }
}
