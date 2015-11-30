using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Tomcat : Cat
    {
        private const string gender = "Male"; 
        public Tomcat(string name, int age): base(name,age,gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("I am a Tomcat and i say Meowww *manly* ");
        }
       
    }
}
