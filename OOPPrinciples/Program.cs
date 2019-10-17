using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Encapsulation.Rectangle rectangle = new Encapsulation.Rectangle();
            rectangle.SetHeigth(10);
            rectangle.SetWidth(20);

            Abstraction.SpanControl spanControl = new Abstraction.SpanControl();
            var output = spanControl.Output();

            Inheritance.DepositAccount depositAccount = new Inheritance.DepositAccount();
            var balance=depositAccount.GetBalance();

            Composition.Car car = new Composition.Car();
            car.Start();

            Polymorphism.DerivedClass derivedClass = new Polymorphism.DerivedClass();
            derivedClass.DoWork();
            Polymorphism.BaseClass baseClass = (Polymorphism.BaseClass)derivedClass;
            baseClass.DoWork();


            MemoryManagement.TestClass test1 = new MemoryManagement.TestClass();
            test1.IntValue = 3;
            MemoryManagement.TestClass test2 = new MemoryManagement.TestClass();
            test2 = test1;
            test2.IntValue = 4;
            int a;
            int b=1;
            Test( out   a);
            Test2(ref b);
            Console.WriteLine(a) ;
            Console.WriteLine(b);

            MemoryManagement.StrTest str1=new MemoryManagement.StrTest();
            Test3(ref str1);
            Test4(out str1);

            MemoryManagement.MethodParameterTest test = new MemoryManagement.MethodParameterTest();

            test.ValueTypeParameter();

            MemoryManagement.CopyProblemTest.Go();
            MemoryManagement.CopyProblemTest c = new MemoryManagement.CopyProblemTest();
            var bla = c.ToString();
            var ttl = GC.GetTotalMemory(true);
            var allc = GC.GetAllocatedBytesForCurrentThread();
            var gc=GC.CollectionCount(0); ;
            var gc1=GC.CollectionCount(1); ;
            var gc2 = GC.CollectionCount(2);
            GC.SuppressFinalize(c);
            
            Console.ReadLine();
        }
 

        public static void Test(out   int b)
        {
           b = 10;
        }

        public static void Test2(ref int b)
        {
            b = 11;
        }

        public static void Test3(ref MemoryManagement.StrTest strTest)
        { }

        public static void Test4(out MemoryManagement.StrTest strTest)
        {
            strTest = new MemoryManagement.StrTest();
        }

    }
}
