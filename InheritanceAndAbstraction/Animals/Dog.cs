﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Dog : Animal
    {
        public Dog(string name, int age, string gender): base(name,age,gender)
        {

        }
        public override void ProduceSound()
        {
            Console.WriteLine("I am a dog and i say Wouf");
        }
    }
}
