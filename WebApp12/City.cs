using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp12
{
    public class City
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public City(string name,string adress)
        {
            Name = adress;
            Address = name;
        }
    }
}
