using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAExceptionsDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                int yearBorn = DateTime.Now.Year - age;
                Console.WriteLine(yearBorn);
            }
            catch (ZeroException)
            {
                if (age < 0)
                {
                    throw new ZeroException();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("There was an internal error.");
            }
            Console.ReadLine();
        }
    }
}
