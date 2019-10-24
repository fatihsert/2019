using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.DependencyInversion
{
    class DIP
    {
        public void Test()
        {
            Calculator addCalculator = new Calculator(new AddOperator());

            addCalculator.Calculate(2, 3);
        }
    }


    /// <summary>
    /// DIP 1. maddesi high level class(modül)=calcualtor. low level ise calcualtionOperator ve gözüktüğü gibi aslında direkt bir bağı yok ikiside abtraction bağlı.
    /// </summary>
    class Calculator
    {
        private ICalculationOperator calculationOperator;

        public Calculator(ICalculationOperator calculationOperator)
        {
            this.calculationOperator = calculationOperator;
        }

        public decimal Calculate(decimal x,decimal y)
        {
            return this.calculationOperator.Calculate(x, y);
        }
    }


    /// <summary>
    /// Abstractions should not depend on details.  
    /// abstraction detaylara bağlı değil aşağıda gözüktüğü sadece calculate methodu var ama ne calculate ediyor bilmiyor.
    /// </summary>
    interface ICalculationOperator
    {
        decimal Calculate(decimal x, decimal y);
    }

    /// <summary>
    ///  Details should depend on abstractions.
    ///  detay ise concrete classta bulunuyor ve abstraction bağlı
    /// </summary>
    class AddOperator : ICalculationOperator
    {
        public decimal Calculate(decimal x, decimal y)
        {
            return x + y;
        }
    }

    class SubtractOperator : ICalculationOperator
    {
        public decimal Calculate(decimal x, decimal y)
        {
            return x - y;
        }
    }
    class MultiplyOperator : ICalculationOperator
    {
        public decimal Calculate(decimal x, decimal y)
        {
            return x * y;
        }
    }

    ///// <summary>
    ///// Calculatorımız bizim high level classımız(modulumuz) oldu .şimdi buraya yeni bir method eklemek istedğimizde OCP ihlal etmiş oluyoruz.
    ///// </summary>
    //class Calculator
    //{
    //    public decimal Add(decimal x, decimal y)
    //    {
    //        return x + y;
    //    }

    //    public decimal Subtract(decimal x, decimal y)
    //    {
    //        return x - y;
    //    }

}
}
