
using System;

namespace Lis
{
    using Titles;

    namespace Workers 
    {
        namespace Management
        {
            class Cleaner
            {
                
            }

            class PoisionCleaner : Cleaner
            {
                
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
            class Nurse:Junior
            {
                 public Nurse(string Name, int MonthlyHours):base(Name, MonthlyHours)
                {
                    this.Salary = this.MonthlyHours * this.SalaryPercentage * this.SalaryPerHour;
                }
            }

            class PrimeNurse : Expert
            {
                public PrimeNurse(string Name, int MonthlyHours):base(Name, MonthlyHours)
                {
                    this.SalaryPercentage = base.SalaryPercentage * 2;
                    this.Salary = this.MonthlyHours * this.SalaryPercentage * this.SalaryPerHour;
                }
                
            }
        }
    }
}
