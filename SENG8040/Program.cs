using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter 1.Enter Trangle Dimansion" + "\n" + "2. Exit ");
            var input = Console.ReadLine();

            if(Convert.ToInt32(input) ==1)
            { 
                while(true)
                { 
                    Console.WriteLine("Enter First Dimansion as Integer");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Dimansion as Integer");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Third Dimansion as Integer");
                    int num3 = Convert.ToInt32(Console.ReadLine());

                    if(TriangleSolver.ValidateTrangle(num1,num2,num3))
                    { 
                            string trangleType =  TriangleSolver.GetTrangleType(num1, num2, num3);
                            Console.WriteLine("Type of Trangle is :  " + trangleType);
                            Console.WriteLine("Press any key X to exit program Or Enter to continue");
                            string exitChar = Console.ReadLine();
                            if(exitChar.ToUpper()== "X")
                            {
                                break;                    
                            }
                    }
                    else
                    {
                        Console.WriteLine(" Input Doesn't form Trangle");
                    }
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }

        
    }
}
