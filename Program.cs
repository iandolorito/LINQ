using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPLOYEE MANAGEMENT SYSTEM");
            var crud = new crud();
            crud.Introduce();
        }
        public static void Option()
        {
            Console.WriteLine("\n============OPTION=========");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Read Employee");
            Console.WriteLine("3. Update Employee");
            Console.WriteLine("4. Delete Eployee");
            Console.WriteLine("5. Exit");    
        }
        public static void viewallorReadone()
        {
            Console.WriteLine("1. List All Employee");
            Console.WriteLine("2. Find Employee by ID");
        }
    }
}
