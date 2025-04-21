// Program:    PCAD_Project_3.1.1
// Date:       21 APR 2025
// Programmer: Thomas A. Morrison

using System;
using System.Globalization;
using System.Text;
namespace PCAD_Project_3_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('0');
            for (int i = 2; i <= 100; i+=2) 
            {
                sb.Append(' ');
                sb.Append(i);
            }
            Console.WriteLine(sb.ToString() + "\n");
            Console.Write("Press any key to continue. ");
            Console.ReadKey();
        }
    }
}