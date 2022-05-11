using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagram
{
    class Car : Vehicle
    {
        private string registrationNumber;
        private string registrationYear;
        private IEngine engine;
        Gearbox g = new Gearbox();
        Wheel frontLeft = new Wheel();
        Wheel fronRight = new Wheel();
        Wheel backLeft = new Wheel();
        Wheel backRight = new Wheel();
        internal Car()
        {

        }
        public Car(string color)
        {

        }
        public Car(string color, float size)
        {

        }
        public void Start()
        {
            engine.Start();
        }
        
        protected override void TurnLeft(float degrees)
        {
            
        }
    }
}
