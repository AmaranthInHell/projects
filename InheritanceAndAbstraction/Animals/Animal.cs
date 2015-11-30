using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal : ISoundProducible
    {
        private string name;
        private int age;
        private string gender;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name cannot be null");
                }
                this.name = value;
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value > 20 || value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be more than 20 or less than 1");
                }
                this.age = value;
            }
        }
        public string Gender
        {
            get { return this.gender; }
            set
            {
                if (value != "Male" && value != "Female" )
                {
                    throw new ArgumentOutOfRangeException("The Gender can only be Male or Female");
                }
                this.gender = value;
            }
        }
        
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;

        }
        public abstract void ProduceSound();
        public override string ToString()
        {
            return string.Format("Name: {0} \nAge: {1} \nGender: {2}", this.Name, this.Age, this.Gender);
        }
    }
}
