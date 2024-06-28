using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Structural_Design_Patterns.Facade_Design_Pattern
{

    // Subsytem Interface - 1
    internal interface IEngine
    {
        void start();

        void stop();
    }

    // Subsytem Interface - 2
    internal interface ILights
    {
        void turnOn();

        void turnOff();
    }


    // Subsystem 1
    class Engine : IEngine
    {
        public void start()
        {
            Console.WriteLine("Engine Started..");
        }

        public void stop()
        {
            Console.WriteLine("Engine Stopped..");
        }
    }

    // Subsystem 2
    class Lights : ILights
    {
        public void turnOn()
        {
            Console.WriteLine("Lights On..");
        }

        public void turnOff()
        {
            Console.WriteLine("Lights Off..");
        }
    }

    // Facade

    class CarFacade
    {
        private IEngine _engine;
        private ILights _lights;
        public CarFacade()
        {
            _engine = new Engine();
            _lights = new Lights();
        }

        public void startCar()
        {
            _engine.start();
            _lights.turnOn();
        }

        public void stopCar()
        {
            _engine.stop();
            _lights.turnOff();
        }
    }

}
