using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.LiskovsSubstitution
{
    #region sorun
    /*
       public class Bird
    {
        public string Name { get; set; }


        public virtual void Flight()
        {
            Console.WriteLine($"{this.Name } am flying");
        }
    }

    public class Pigeon : Bird
    {
        public Pigeon()
        {
            this.Name = "a-Pigeon";
        }

    }

    public class Chicken:Bird
    {
        public override void Flight()
        {
            Console.WriteLine("I can not fly. because I am chicken:(");
        }
    }*/
    #endregion

    #region cozum
    public class Bird
    {
        public string Name { get; set; }
    }

    public class FlyableBird : Bird
    {
        public  void Flight()
        {
            Console.WriteLine("I can not fly. because I am chicken:(");
        }
    }

    public class Pigeon : FlyableBird
    {
        public Pigeon()
        {
            this.Name = "a-Pigeon";
        }

    }

    public class Chicken : Bird
    {
      
    }
    #endregion
    public class liskov
    {
        static void Test()
        {
            FlyableBird bird = new Pigeon();

            bird.Flight();

            Bird chicken = new Chicken();

            // tavuk uçamaz o yüzden liskovu bozan bir durum olumakta bunun yerine çözü olarak
            //chicken.Flight();
        }
    }
}
