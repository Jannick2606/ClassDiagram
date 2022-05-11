using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    class Factory
    {
        private Factory()
        {

        }
        public static void Instance()
        {

        }
        public Vehicle Create(int type)
        {
            Vehicle vehicle = new Car();
            return vehicle;
        }
    }
}
