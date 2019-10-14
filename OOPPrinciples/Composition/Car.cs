using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Composition
{
    public class Car
    {
        private Engine Eng;

        public Car()
        {
            Eng = new Engine();
        }
        public void Start()
        {
            Eng.Start();
        }
    }

    class Engine
    {
        internal void Start()
        {

            //check gass
            //check electricity
        }
    }
}
