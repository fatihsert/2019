using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.MemoryManagement
{
    // public struct Shoe

    public class Shoe
    {
        public string Color;
    }
    public class Dude
    {
        public string Name;
        public Shoe RightShoe;
        public Shoe LeftShoe;
        public Dude CopyDude()
        {
            Dude newPerson = new Dude();
            newPerson.Name = Name;
            newPerson.LeftShoe = LeftShoe;
            newPerson.RightShoe = RightShoe;
            return newPerson;
        }
        public override string ToString()
        {
            return (Name + " : Dude!, I have a " + RightShoe.Color + " shoe on my right foot, and a " + LeftShoe.Color + " on my left foot.");
        }
    }

    class CopyProblemTest
    {
        ~CopyProblemTest()
        {

        }
       public static void Go()
        {
            Dude Bill = new Dude();
            Bill.Name = "Bill";
            Bill.LeftShoe = new Shoe();
            Bill.RightShoe = new Shoe();
            Bill.LeftShoe.Color = Bill.RightShoe.Color = "Blue";
            Dude Ted = Bill.CopyDude();
            Ted.Name = "Ted";
            Ted.LeftShoe.Color = Ted.RightShoe.Color = "Red";
            Console.WriteLine(Bill.ToString());
            Console.WriteLine(Ted.ToString());
        }
    }
}
