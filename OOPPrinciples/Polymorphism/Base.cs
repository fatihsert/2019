using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Polymorphism
{
    public class BaseClass
    {
        public virtual void DoWork() { Console.WriteLine("baseclass"); }
        public virtual int WorkProperty
        {
            get { return 0; }
        }
    }
    public class DerivedClass : BaseClass
    {
        public override void DoWork() { Console.WriteLine("derivedclass"); }
        public override int WorkProperty
        {
            get { return 0; }
        }
    }
}
