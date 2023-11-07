using System.Runtime.CompilerServices;
using System.Security;

namespace odd_even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj liczbę całkowitą i naciśnij Enter.");
                int userNumber = GetNumber();
                if (userNumber % 2 == 0)
                {
                    Console.WriteLine("Podałeś liczbę parzystą.");
                }
                else
                    Console.WriteLine("Podałeś liczbę nieparzystą.");

                var value = "y";

                while (value == "y")
                {
                    Console.WriteLine("Czy chcesz kontynuować? Y/N");
                    value = Console.ReadLine();
                    if (value.ToLower() == "n")
                        Environment.Exit(0);
                    else if (value.ToLower() == "y")
                        break;
                    else
                    {
                        Console.WriteLine($"Wprowadiłeś niewłaściwą wartość {value}\nWprowadź Y aby kontynuować lub N by zakończyć");
                        value = "y";
                    }
                }
            }

            static int GetNumber()
            {
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out int userNumber))
                    {
                        Console.WriteLine("Wprowadzona wartość nie jest liczbą całkowitą\nSpróbuj jeszcze raz.");
                        continue;
                    }
                    return userNumber;
                }

            }


        }
    }
}