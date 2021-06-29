
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
            class PrimeNurse:Worker
            {
                 public PrimeNurse(string Name, int MonthlyHours):base(Name, MonthlyHours)
                {
                    this.Salary = this.MonthlyHours * Manager.SalaryPercentageAddition * DescionMaker.SalaryPercentageAddition * this.SalaryPerHour; 

                }
            }

        }
    }
}
