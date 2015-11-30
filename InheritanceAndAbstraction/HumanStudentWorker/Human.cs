using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    public abstract class Human
    {
        private string fName;
        private string lName;
        public string FName
        {
            get { return this.fName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name cannot be empty or null");
                }
                this.fName = value;
            }
        }
        public string LName
        {
            get { return this.lName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The second name cannot be empty or null");
                }
                this.lName = value;
            }
        }
        public Human(string fName, string lName)
        {
            this.FName = fName;
            this.LName = lName;
        }
       
        public override string ToString()
        {
            return string.Format("{0}, {1}",FName,LName); 
        }


    }
}
