
using System;

namespace Lis
{
    using Titles;
    using Workers.Professional;
    using Workers.Management;
 
    class Program
    {
        static void Main(string[] args)
        {
           Manager El = new Manager(Name:"El",MonthlyHours:2);
        //    PrimeNurse Ae = new PrimeNurse();
           Console.WriteLine(El.Salary);
        //    Console.WriteLine(Ae.SalaryPercentage);
           
           Console.WriteLine("whoami");
           
        }
    }
}
