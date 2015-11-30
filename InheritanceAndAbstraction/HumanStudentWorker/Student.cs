using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public class Student : Human
    {
        private int facNumber;
        public int FacNumber
        {
            get { return this.facNumber; }
            set
            {
                if (value.ToString().Length < 5 || value.ToString().Length > 10)
                {
                    throw new ArgumentOutOfRangeException("The faculty number must be minimum 5 digits and maximum 10");
                }
                this.facNumber = value;
            }
        }
        public Student(string fName, string lName, int facNumber) : base(fName, lName)
        {
            this.FacNumber = facNumber;
        }
       
        public override string ToString()
        {
            return base.ToString() +" "+ this.FacNumber;
        }



    }
}
