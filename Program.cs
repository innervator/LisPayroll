
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
            // reading workers list
            // string[] lines = System.IO.File.ReadAllLines(@".\WorkersLIst.txt");
            // Worker[] workers = new Worker[lines.Length]; 
            // int lineNumber = 0;

            // foreach (string line in lines)
            // {
            //     lineNumber+=1;
            //     string[] worker = line.Split(":");
            //     switch (worker[0])
            //     {
            //         case "manager":
            //             Manager manager = new Manager(Name:worker[1],MonthlyHours:Convert.ToInt32(worker[2]));
            //             workers[lineNumber] = manager;
            //             break;
            //         case "senior":
            //             Senior senior = new Senior(Name:worker[1],MonthlyHours:Convert.ToInt32(worker[2]));
            //             workers[lineNumber] = senior;
            //             break;
            //         default:
            //             Console.WriteLine(worker[1]+" title didn't match any of the titles");
            //             break;
            //     }
            // }

            PrimeNurse El = new PrimeNurse(Name:"El",MonthlyHours:2);
        //    PrimeNurse El = new PrimeNurse(Name:"Aie",MonthlyHours:5);
            Console.WriteLine(El.Salary);
        //    Console.WriteLine(Ae.SalaryPercentage);
           
           Console.WriteLine("whoami");
           
        }
    }
}
