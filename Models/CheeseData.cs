using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseData
    {
        private static List<Cheese> cheeses = new List<Cheese>();

        public static List<Cheese> GetAll()
        {
            return cheeses;
        }

        public static void Add(Cheese cheese)
        {
            cheeses.Add(cheese);
        }

        public static void Remove(int id)
        {
            cheeses.Remove(GetById(id));
        }

        public static Cheese GetById(int id)
        {
            return cheeses.Single( c => c.ID == id);
        }
    }
}