
using System;

namespace Lis
{
    namespace Titles 
        {
        public class Worker
        {
            public string Name;
            public int MonthlyHours;
            public double SalaryPerHour = 10;
            private double salaryPercentage = 1;
            public double Salary = 0;
            public double SalaryPercentageAddition = 1;
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
            }
        }

        public sealed class Manager:Worker
        {
            public new static double SalaryPercentageAddition = 5;
            
            public Manager(string Name, int MonthlyHours):base(Name, MonthlyHours)
            {

            }
        }

        public sealed class Senior:Worker
        {
            public new static double SalaryPercentageAddition = 1.05;
            public Senior(string Name, int MonthlyHours):base(Name, MonthlyHours)
            {
            }
        }

        public class Expert:Worker
        {
            public new static double SalaryPercentageAddition = 1.3;
            public Expert(string Name, int MonthlyHours):base(Name, MonthlyHours)
            {
            }
        }

        public sealed class DescionMaker:Worker
        {
            private int monthlyHours;

            public new static double SalaryPercentageAddition = 2;
            public int MonthlyHours
            {
                get
                {
                    return monthlyHours;
                }
                set
                {
                    monthlyHours = value;
                    if(monthlyHours > 50)
                    {
                        SalaryPercentageAddition = 200*2;
                        monthlyHours=1;
                    }

                }
            }

            public DescionMaker(string Name, int MonthlyHours):base(Name, MonthlyHours)
            {
                this.SalaryPercentage = base.SalaryPercentage * 3;
                this.MonthlyHours = MonthlyHours;
                this.Salary = this.MonthlyHours * this.SalaryPercentage * this.SalaryPerHour;
            }
        }

        public sealed class AtRisk:Worker
        {
            public AtRisk(string Name, int MonthlyHours, int RiskPercentage):base(Name, MonthlyHours)
            {
                this.SalaryPercentage = base.SalaryPercentage * 2;
                this.Salary = this.MonthlyHours * this.SalaryPercentage * this.SalaryPerHour * (RiskPercentage/100+1);
            }
        }
    }
}
