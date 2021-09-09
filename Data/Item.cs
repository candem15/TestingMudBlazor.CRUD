using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace  TestingMudBlazor.CRUD.Data
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public int Weight { get; set; }
        public int Durability { get; set; }
        public int Attack { get; set; }
        public int Defence { get; set; }

    }

}