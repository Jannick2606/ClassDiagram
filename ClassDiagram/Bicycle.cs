using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    class Bicycle: IBreakeable
    {
        private string registrationNumber;
        public Bicycle(int numberOfWheels)
        {
            List<Wheel> wheels = new List<Wheel>(numberOfWheels);
        }

        public void Brake()
        {
            
        }
    }
}
