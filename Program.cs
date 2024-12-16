using System.Security;

namespace Set2Ex16
{
    internal class Program
    {
        static bool EsteBitonicaRotita(int[] secventa)
        {
            int n = secventa.Length;
            if (n < 3)
            {
                return false;
            }

            int schimbariDirectie = 0;
            for(int i = 0; i < n; i++)
            {
                int urmatorulNumar = (i + 1) % n;
                if (secventa[i]  < secventa[urmatorulNumar])
                {
                    if(i > 0 && secventa[i-1] > secventa[i])
                    {
                        schimbariDirectie++;
                    }
                }
                else if (secventa[i] > secventa[urmatorulNumar])
                {
                    if( i > 0 && secventa[i-1] < secventa[i])
                    {
                        schimbariDirectie++;
                    }
                }
            }

            return schimbariDirectie >= 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti o serie de numere separate prin spatiu: ");
            string input = Console.ReadLine();
            int[] secventa = Array.ConvertAll(input.Split(' '), int.Parse);

            bool rezultat = EsteBitonicaRotita(secventa);

            Console.WriteLine("Este bitonica rotita: " + rezultat);
        }
    }
}
