using System.Security;

namespace AS2425._3F.INF.Prof.Massimo2Numeri
{
    internal class Program
    {


        /// <summary>
        /// Questo è il punto di avvio del mio programma
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // dichiarazioni variabili
            string? numero;

            // intestazione chi, dove, quando, cosa
            Console.WriteLine("Prof;3F;7/10/24;Calcolo del massimo fra 2 numeri");

            // dammi il primo numero
            Console.WriteLine("Dammi il primo numero");
            numero = Console.ReadLine();

            // convertilo ad intero
            int numero1 = Convert.ToInt32(numero);

            // dammi il secondo numero
            Console.WriteLine("Dammi il secondo numero");
            numero = Console.ReadLine();

            // convertilo ad intero
            int numero2 = Convert.ToInt32(numero);

            // verifica quale è il maggiore
            if (numero1 > numero2)
            {
                Console.WriteLine($" {numero1}  è maggiore di {numero2}");
            }
            else
            {
                Console.WriteLine($" {numero1}  è minore/uguale a {numero2}");
            }

        }
    }
}
