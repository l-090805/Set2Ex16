using System.Security;

namespace Set2Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numarul de elemente din secventa: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 2)
            {
                Console.WriteLine("Secventa este bitonica rotita."); 
                return;
            }

            Console.WriteLine("Introduceti elementele secventei: ");
            int primulElement = int.Parse(Console.ReadLine());
            int elementAnterior = primulElement;
            int elementCurent;

            int tranzitii = 0; 
            bool crescator = true; 

            for (int i = 1; i < n; i++)
            {
                elementCurent = int.Parse(Console.ReadLine());

                if (crescator)
                {
                    if (elementCurent < elementAnterior)
                    {
                        tranzitii++;
                        crescator = false;
                    }
                }
                else
                {
                    if (elementCurent > elementAnterior)
                    {
                        tranzitii++;
                        crescator = true;
                    }
                }

                elementAnterior = elementCurent;
            }

            if (crescator && primulElement < elementAnterior)
            {
                tranzitii++;
            }
            else if (!crescator && primulElement > elementAnterior)
            {
                tranzitii++;
            }

            if (tranzitii <= 2)
            {
                Console.WriteLine("Secventa este bitonica rotita.");
            }
            else
            {
                Console.WriteLine("Secventa NU este bitonica rotita.");
            }
        }
    }
}
