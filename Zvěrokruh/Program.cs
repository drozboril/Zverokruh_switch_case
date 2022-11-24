using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zvěrokruh_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napište znamení zvěrokruhu");
            string vstup = Console.ReadLine();

            switch (vstup)
            {
                case "beran":
                case "Beran":
                Console.WriteLine("21. 3 - 20. 4.");
                break;
                case "byk":
                case "býk":
                case "Byk":
                case "Býk":
                Console.WriteLine("21. 4. - 21. 5.");
                break;
                case "blizenci":
                case "blíženci":
                case "Blizenci":
                case "Blíženci":
                Console.WriteLine("22. 5. - 21. 6.");
                break;
                case "rak":
                case "Rak":
                Console.WriteLine("22. 6. - 22. 7.");
                break;
                case "lev":
                case "Lev":
                Console.WriteLine("23. 7. - 22. 8.");
                break;
                case "panna":
                case "Panna":
                Console.WriteLine("23. 8. - 22. 9.");
                break;
                case "vahy":
                case "váhy":
                case "Vahy":
                case "Váhy":
                Console.WriteLine("23. 9. - 23. 10.");
                break;
                case "stir":
                case "štír":
                case "Stir":
                case "Štír":
                Console.WriteLine("24. 10. - 22. 11.");
                break;
                case "strelec":
                case "střelec":
                case "Strelec":
                case "Střelec":
                Console.WriteLine("23. 11. - 21. 12.");
                break;
                case "kozoroh":
                case "Kozoroh":
                Console.WriteLine("22. 12. - 20. 1.");
                break;
                case "vodnar":
                case "vodnář":
                case "Vodnar":
                case "Vodnář":
                Console.WriteLine("21. 1. - 20. 2.");
                break;
                case "ryby":
                case "Ryby":
                Console.WriteLine("21. 2. - 20. 3.");
                break;
            }
            Console.ReadLine();
        }
    }
}