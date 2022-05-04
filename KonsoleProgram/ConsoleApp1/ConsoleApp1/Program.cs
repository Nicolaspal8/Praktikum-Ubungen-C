using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aufgabe 1
            Console.WriteLine("Hello World!");

            //Aufgabe 2
            Console.WriteLine("Wie heißt du?");
            string name = Console.ReadLine();
            Console.WriteLine("Wie Alt bist du?");
            string age = Console.ReadLine();

            Console.WriteLine("Hallo {0}\nDu bist {1} Jahre Alt ganz Jung", name, age);

            //Aufgabe 3
            using (StreamWriter write = new StreamWriter(@"C:\Users\Schulung\Desktop\Text.txt"))
            {
                write.WriteLine(name);
                write.WriteLine(age);
            }
            Console.WriteLine("----------Text File-----------");

            //Aufgabe 4
            using (StreamReader read = new StreamReader(@"C:\Users\Schulung\Desktop\Text.txt"))
            {
                while (!(read.EndOfStream))
                {
                    string line = read.ReadLine();
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();

            //Aufgabe 5
            //double number1;
            //double number2;
            //do
            //{
            //    try
            //    {
            //        Console.WriteLine("ein Nummer bitte");
            //        number1 = Convert.ToDouble(Console.ReadLine());
            //        Console.WriteLine("nochmal ein Nummer bitte");
            //        number2 = Convert.ToDouble(Console.ReadLine());
            //        double summe = number1 + number2;
            //        double subtraktion = number1 - number2;
            //        double multiplikation = number1 * number2;
            //        double abteilung = number1 / number2;

            //        Console.WriteLine("die Summe ist: " + summe);
            //        Console.WriteLine("die Subtraktion ist: " + subtraktion);
            //        Console.WriteLine("die Multiplikation ist: " + multiplikation);
            //        Console.WriteLine("die Abteilung ist: " + abteilung);

            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Fehler, bitte nur nummer");
            //    }
            //}
            //while (true);




        }
    }
}
