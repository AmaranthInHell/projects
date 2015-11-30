using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public class Worker : Human
    {
         

        private decimal weekSalary;
        private decimal workHoursPerDay;

        
        
        public decimal WeekSalary
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0 )
                {
                    throw new ArgumentOutOfRangeException("The week salary cannot be negative");
                }
                this.weekSalary = value;
            }
        }
        public decimal WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The work hours per day cannot be negative");
                }
                this.workHoursPerDay = value;
            }
        }

        public Worker(string fName, string lName, decimal weekSalary, decimal workHoursPerDay) : base(fName, lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public  decimal  PaymentPerHour()
        {
            
            return (this.WeekSalary / 5m) / this.WorkHoursPerDay;

        }
        
        public override string ToString()
        {
            return base.ToString() + " " + this.PaymentPerHour().ToString("f2");
        }
    }
}
