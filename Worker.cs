
using System;

namespace Lis
{
    public class Worker
    {
        private double _salary = 1;
        public virtual double SalaryPercentage
        { 
            get 
            { 
            return _salary; 
            } 
            set 
            { 
            _salary = value; 
            } 
        }

    }


    public sealed class Manager:Worker
    {
        public Manager()
        {
            this.SalaryPercentage = base.SalaryPercentage * 1.5;
        }
    }

    public sealed class Expert:Worker
    {
        public Expert()
        {
            this.SalaryPercentage = base.SalaryPercentage * 2;
        }
    }
}
