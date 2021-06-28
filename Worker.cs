
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
        public override double SalaryPercentage
        {
            get
            {
                return base.SalaryPercentage;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                base.SalaryPercentage = value;
            }
        }

        public Manager()
        {
            this.SalaryPercentage = 1.5;
        }
    }
}
