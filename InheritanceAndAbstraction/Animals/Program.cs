using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[10]
            {
                new Cat("Ivanka", 10, "Female"),
                new Dog("Doge",12,"Male"),
                new Frog("Jabcho",15,"Male"),
                new Kitten("Gergina",8),
                new Tomcat("Goshko",6),
                new Cat("Dragan",1,"Male"),
                new Dog("Dogina",4,"Female"),
                new Frog("Jabka",9,"Female"),
                new Kitten("Dora",19),
                new Tomcat("Tom", 20)
            };
            animals.ToList().ForEach(Console.WriteLine);
            Console.ReadKey();

            animals.GroupBy(animal => animal.GetType().Name).Select(group => new
            {
                AnimalName = group.Key,
                AverageAge = group.Average(age => age.Age)
            })
                .OrderBy(group => group.AverageAge)
                .ToList()
                .ForEach(group => Console.WriteLine($"{group.AnimalName}'s average age is: {group.AverageAge}"));
        }
    }
}
