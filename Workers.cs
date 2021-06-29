
using System;

namespace Lis
{
    using Titles;

    namespace Workers 
    {
        namespace Management
        {
            class Cleaner:Worker
            {
                public Cleaner(string Name, int MonthlyHours):base(Name, MonthlyHours)
                {
                    this.Salary = this.MonthlyHours * Senior.SalaryPercentageAddition * Expert.SalaryPercentageAddition * this.SalaryPerHour; 

                }
            }

            class PoisionCleaner : Cleaner
            {
                public PoisionCleaner(string Name, int MonthlyHours):base(Name, MonthlyHours)
                {
                    this.Salary = this.MonthlyHours * Senior.SalaryPercentageAddition * Expert.SalaryPercentageAddition * this.SalaryPerHour; 

                }
            }

            class MasterCleaner
            {

            }

            class CleanerCharger
            {

            }

            class CleanerShiftSupervisor
            {

            }

            class Cook
            {

            }

            class SousChef : Cook
            {

            }

            class Chef : Cook
            {

            }

            class FoodProvider
            {
                
            }
        }
        namespace Professional
        {
            class PrimeNurse:Worker
            {
                 public PrimeNurse(string Name, int MonthlyHours):base(Name, MonthlyHours)
                {
                    this.Salary = this.MonthlyHours * Senior.SalaryPercentageAddition * Expert.SalaryPercentageAddition * this.SalaryPerHour; 

                }
            }

        }
    }
}
