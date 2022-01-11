using System;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nrAlbumu="117794";
            string sciezkaOdczytu = "zapis.txt";

            using (var sw = new StreamWriter("zapis.txt", append: false))
            {
                sw.WriteLine(nrAlbumu);
            }


            using (var sr = new StreamReader(sciezkaOdczytu))
            {
                Console.Write(sr.ReadToEnd());
            }

            Console.WriteLine();
            int przedOstatnia;
            int liczbaKobiet=0;

            using (var sr = new StreamReader("pesels.txt"))
            {
                var line = sr.ReadLine();
                while (line != null) 
                {
                    przedOstatnia = line[line.Length - 2] - '0';

                    Console.WriteLine(line);
                    Console.WriteLine(przedOstatnia);

                    if (przedOstatnia % 2 == 1)
                    {
                        Console.WriteLine("nieparzysta");
                        liczbaKobiet++;
                        Console.WriteLine(liczbaKobiet);
                    }
                    else
                    {
                        Console.WriteLine("parzysta");
                        Console.WriteLine(liczbaKobiet);
                    }


                    line = sr.ReadLine();
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine(liczbaKobiet);

        }
    }
}
