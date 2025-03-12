using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    class ListDataAccess : IDataAccess
    {

        public static List<Product> Products = new List<Product>()
        {
            new Product(){ Name = "XBOX", Price = 399.99},
            new Product(){Name = "Nintendo Switch", Price = 379.99},
            new Product(){Name = "HeadPhones", Price = 49.99},
            new Product(){Name = "Skyrim", Price = 56.99},
            new Product(){Name = "Animal Crossing", Price = 49.99}

        };
        public List<Product> LoadData()
        {
            Console.WriteLine("I am reading data from List Data Access");
            return Products;
        }

        public void SaveData()
        {
            Console.WriteLine("I am saving data to a List database");
        }
    }
}
