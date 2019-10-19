using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.SingleResponsibility
{
    /// <summary>
    /// sorumlulukları
    /// 1. calcualtepay bu bir business method.
    /// 2. save database işlemleri
    /// 3. employeeinfo ile raporlama işlemleri için bir  output üretmek.
    /// 
    /// 3 farklı sorumluğu var. bu durumda bu classı 3 farklı class ayırmamız gerekiyor.
    /// 1.EmployeeSalaryManager
    /// 2.EmployeeRepository
    /// 3.EmployeeReport
    /// </summary>
    public class Employee
    {
        public decimal CalculatePay()
        {
            //some database operation
            //using dependent other class
            return 0;
        }


        public bool Save()
        {
            //some database operation

            return true;
        }

        public string EmployeeInfo()
        {
            //some database operation
            //employe info build
            return string.Empty;
        }
    }
}
