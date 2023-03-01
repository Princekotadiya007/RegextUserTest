using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexUserRegistration
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flge = true;
            RegexPrograms regex = new RegexPrograms();
            while (flge)
            {
                Console.WriteLine("Welcom to User Registration");
                Console.WriteLine("\n1.ValidFirstName");
                Console.WriteLine("choose the option");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        //RegexPrograms regex = new RegexPrograms();
                        regex.ValidateFirstName("Prince");
                        break;
                    case 10:
                        flge = false;
                        break;
                }
            }
        }
    }
}
