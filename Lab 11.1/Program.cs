using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = Console.ReadLine();
            string resultFullName = string.Empty;

            Console.WriteLine("Length: " + fullName.Length);

            fullName = fullName.TrimStart();

            int position = fullName.IndexOf(" ");
            resultFullName = fullName.Substring(0, position + 2) + ".";
            fullName = fullName.Remove(0, position + 2);
            position = fullName.IndexOf(" ");
            resultFullName += fullName.Substring(position, 2) + ".";

            Console.WriteLine(resultFullName);
            Console.ReadKey();
        }
    }
}
