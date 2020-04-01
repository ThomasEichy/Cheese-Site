using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class Cheese
    {
        private static int nextID = 1;
        public string Name { get; set; }
        public string Description { get; set; }
        public int ID { get; set;}

        public Cheese()
        {
            ID = nextID++;
        }
    }
}