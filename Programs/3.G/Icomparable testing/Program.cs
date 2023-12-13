using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icomparable_testing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> list = new List<Student>();
            Random rnd = new Random();

            for (int i = 0; i < 10000; i++)
            {
                list.Add(new Student("Student", rnd.Next(15,19), rnd.Next(-3,13)));
                
            }
            
            list.Sort();

            foreach (var item in list)
            {
                
                Console.WriteLine($"StudentId: {item.Id:0000} | Name: {item.Name} | Age: {item.Age} | Average: {item.Average:00;-0}");
                
            }
        }
    }
}
