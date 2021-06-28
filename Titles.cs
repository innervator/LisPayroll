
using System;

namespace Lis
{
    namespace Titles 
        {
        public class Worker
        {
            public string Name;
            public int MonthlyHours;
            private double salaryPercentage = 1;
            
            public double Salary = 0;
            public virtual double SalaryPercentage
            { 
                get 
                { 
                return salaryPercentage; 
                } 
                set 
                { 
                salaryPercentage = value; 
                } 
            }

            public Worker(string Name, int MonthlyHours)
            {
                this.Name = Name;
                this.MonthlyHours = MonthlyHours;
                this.Salary = this.MonthlyHours * this.SalaryPercentage;

            }

             

        }

        public class Junior : Worker
        {
            public Junior(string Name, int MonthlyHours):base(Name, MonthlyHours)
            {
                this.Name = Name;
                this.MonthlyHours = MonthlyHours;

            }
        }

        public sealed class Manager:Worker
        {
            public Manager(string Name, int MonthlyHours):base(Name, MonthlyHours)
            {
                this.Name = Name;
                this.MonthlyHours = MonthlyHours;
                this.SalaryPercentage = base.SalaryPercentage * 5;
                this.Salary = this.MonthlyHours * this.SalaryPercentage;

            }
        }

        public sealed class Senior:Worker
        {
            public Senior(string Name, int MonthlyHours):base(Name, MonthlyHours)
            {
                this.Name = Name;
                this.MonthlyHours = MonthlyHours;
                this.SalaryPercentage = base.SalaryPercentage * 2;

            }
        }

        public class Expert:Worker
        {
            public Expert(string Name, int MonthlyHours):base(Name, MonthlyHours)
            {
                this.Name = Name;
                this.MonthlyHours = MonthlyHours;
                this.SalaryPercentage = base.SalaryPercentage * 3;
            }
        }

        public sealed class DescionMaker:Worker
        {
            public DescionMaker(string Name, int MonthlyHours):base(Name, MonthlyHours)
            {
                this.Name = Name;
                this.MonthlyHours = MonthlyHours;
                this.SalaryPercentage = base.SalaryPercentage * 4;
            }
        }

        public sealed class AtRisk:Worker
        {
            public AtRisk(string Name, int MonthlyHours, int RiskPercentage):base(Name, MonthlyHours)
            {
                this.Name = Name;
                this.MonthlyHours = MonthlyHours;
                this.SalaryPercentage = base.SalaryPercentage * RiskPercentage;
            }
        }
    }
}
