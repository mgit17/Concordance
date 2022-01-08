using Concordance.Models;
using System;

namespace Concordance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Insert Filename:");
                var input = Console.ReadLine(); 

                var file = new MyFile(input);
                var service = new Services.ConcordanceService();
                var concordance = service.Generate(file);
                var result = service.FormatConcordance(concordance);

                Console.WriteLine(result);                
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
                Console.WriteLine("Error:");
                Console.WriteLine(ex?.Message);
                Console.WriteLine("Press any key to close this window");
            }
        }
    }
}