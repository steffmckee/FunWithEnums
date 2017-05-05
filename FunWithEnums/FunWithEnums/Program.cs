using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithEnums
{
    // A custom enumeration.
    //enum EmpType
    //{
    //    Manager,        // = 0
    //    Grunt,          // = 1
    //    Contractor,     // = 2
    //    VicePresident   // = 3
    //}

    // This time, EmpType maps to an underlying byte.
    enum EmpType : byte
    {
        Manager = 10,
        Grunt = 1,
        Contractor = 100,
        VicePresident = 9
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Enums *****\n");
            EmpType emp = EmpType.Contractor;
            AskForBonus(emp);

            // Print storage for the enum.
            //Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(emp.GetType()));
            Console.WriteLine("EmpType uses a {0} for storage", Enum.GetUnderlyingType(typeof(EmpType)));

            Console.WriteLine("{0} = {1}", emp.ToString(), (byte)emp);
            Console.WriteLine();

            EmpType e2 = EmpType.Contractor;
            DayOfWeek day = DayOfWeek.Monday;
            ConsoleColor cc = ConsoleColor.Gray;

            EvaluateEnum(e2);
            EvaluateEnum(day);
            EvaluateEnum(cc);

            Console.ReadLine();
        }

        static void AskForBonus(EmpType e)
        {
            switch (e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir!");
                    break;
            }
        }

        static void EvaluateEnum(System.Enum e)
        {
            Console.WriteLine("=> Information about {0}", e.GetType().Name);

            Console.WriteLine("Underlying storage type: {0}", Enum.GetUnderlyingType(e.GetType()));

            // Get all name/value pairs for incoming parameter.
            Array enumData = Enum.GetValues(e.GetType());
            Console.WriteLine("This enum has {0} members.", enumData.Length);

            for (int i = 0; i < enumData.Length; i++)
            {
                Console.WriteLine("Name: {0}, Value: {0:D}", enumData.GetValue(i));
            }
            Console.WriteLine();
        }
    }
}
