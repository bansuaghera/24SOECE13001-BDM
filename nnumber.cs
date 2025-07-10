using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE13001_BDM
{
    internal class Profile
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of terms:");
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int b;
            Console.WriteLine("Enter The Number");
            b = Convert.ToInt32(Console.ReadKey());

            for (int i = 0; i < a; i++)
            {
                for (int j =0; j < b; j++)
                {
                    Console.WriteLine(b);
                }
            }

            Console.ReadLine();
        }
    }
}
