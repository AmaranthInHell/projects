using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HumanStudentWorker;
namespace HumanStudentWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            Human workerAlpha = new Worker("Petar", "Georgiev",250,6);
            //Console.WriteLine(workerAlpha);
            List<Student> students = new List<Student>
            {
            new Student("Petar", "Ivanov",1023456789),
            new Student("Ivan", "Petrov",923456788),
            new Student("Mihail", "Ivanov",823456787),
            new Student("Ivan", "Mihailov",723456786),
            new Student("Mihail","Petrov",623456785),
            new Student("Petar","Mihailov",523465784),
            new Student("Georgi","Petrov",432465783),
            new Student("Petar","Georgiev",323456782),
            new Student("Georgi","Ivanov",223465781),
            new Student("Ivan","Georgiev",132465780),
            };
            var sortedStudentByFacultyNumber = students.OrderBy(s => s.FacNumber);
         
            Console.WriteLine(string.Join(Environment.NewLine, sortedStudentByFacultyNumber.Select(s => s.ToString())));
            Console.Write(Environment.NewLine);
            List<Worker> workers = new List<Worker>
            {
            new Worker("Petar", "Ivanov",250,6),
            new Worker("Ivan", "Petrov",300,6),
            new Worker("Mihail", "Ivanov",350,6),
            new Worker("Ivan", "Mihailov",200,6),
            new Worker("Mihail","Petrov",150,6),
            new Worker("Petar","Mihailov",100,6),
            new Worker("Georgi","Petrov",50,6),
            new Worker("Petar","Georgiev",250,7),
            new Worker("Georgi","Ivanov",200,7),
            new Worker("Ivan","Georgiev",150,7),
            };

            var sortedWorkerByPaymentPerHour = workers.OrderByDescending(w => w.PaymentPerHour());
            Console.WriteLine(string.Join(Environment.NewLine, sortedWorkerByPaymentPerHour.Select(w => w.ToString())));
            Console.Write(Environment.NewLine);
            List<Human> humans = new List<Human>();

            humans.AddRange(students);
            humans.AddRange(workers);
            var sortHumansByNames = humans
                .OrderBy(h => h.FName)
                .ThenBy(h => h.LName)
                .Select(h => h.FName + " " + h.LName + " - " + h.GetType() );
            Console.WriteLine(string.Join(Environment.NewLine, sortHumansByNames));
        }
    }
}

