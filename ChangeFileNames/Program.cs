using System;
using System.IO;
using System.Linq;

namespace ChangeFileNames
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il path della cartella");
            string folderPath = Console.ReadLine();

            Console.WriteLine("inserisci l'estensione dei file");
            string fileExtension = Console.ReadLine();

            Console.WriteLine("inserisci il numero dal quale iniziare (il nome)");
            string fileName = Console.ReadLine();

            int i = Int32.Parse(fileName);

            try
            {
                var files = Directory.GetFiles(folderPath, $"*{fileExtension}").Select(Path.GetFileName);

                foreach (var file in files)
                {
                    File.Move(Path.Combine(folderPath, file), Path.Combine(folderPath, $"{i++}{fileExtension}"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Fine programma!");
            Console.Read();
        }
    }
}
