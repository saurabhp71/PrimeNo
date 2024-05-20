using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNo
{
    internal class Program
    {
        static bool checkForPrime(int n, int i)
        {

            // Base cases 

            // Add changes
            if (n <= 2)
            {
                return (n == 2) ? true : false;
            }
                
            if (n % i == 0)
            {
                return false;
            }
                
            if (i * i > n)
            {
                return true;
            }
                

            // Check for next divisor 
            return checkForPrime(n, i + 1);
        }
        static void Main(string[] args)
        {
            int n1;
            Console.Write(" Input any positive number : ");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (checkForPrime(n1, 2))
            {
                Console.Write("The number {0} is a prime number.", n1);
            }
            else
            {
                Console.Write("The number {0} is not a prime number.", n1);
            }
            Console.ReadKey();
        }
    }
}
