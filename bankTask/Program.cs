using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
        tryagain:
            Console.Write("                             Username: ");
            string user = Console.ReadLine();
            Console.Write("                             Password: ");
            string password = Console.ReadLine();
            if (user != "admin" && password != "admin")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Istifadeci adini ve parolu duzgun daxil edin");
                Console.ResetColor();
                goto tryagain;

            }

            else
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("                                Welcome Bank");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("  [1] Kredit goturmek");
                Console.WriteLine("  [2] Kredit odemek");
                Console.WriteLine("  [3] Hesabat");

                Console.Write("Seciminizi daxil edin: ");
                int secim = int.Parse(Console.ReadLine());
                Console.Clear();
                int month = 0;
                double umumi_mebleg = 0;
                double mebleg;
                double odenis = 0;
                double borc = 0;
                int qalan_ay = 0;
                if (secim == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1. Ay daxil edin: ");
                    Console.ResetColor();
                    month = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(@"1 illik faiz 12%
1 ilden cox olanda faiz 18%");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Meblegi daxil edin: ");
                    Console.ResetColor();
                    mebleg = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    if (month <= 12)
                    {
                        umumi_mebleg = (mebleg + (mebleg * 0.12));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Umumi odenecek mebleg: ");
                        Console.ResetColor();
                        Console.WriteLine(umumi_mebleg);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Ayliq odenis: ");
                        Console.ResetColor();
                        odenis = umumi_mebleg / month;
                        Console.WriteLine(odenis);
                    }
                    else if (month > 12)
                    {
                        umumi_mebleg = (mebleg + (mebleg * 0.18));
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Umumi odenecek mebleg: ");
                        Console.ResetColor();
                        Console.WriteLine(umumi_mebleg);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Ayliq odenis: ");
                        Console.ResetColor();
                        odenis = umumi_mebleg / month;
                        Console.WriteLine(odenis);
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(@"Razisiz?
[1] Beli
[2] Xeyr");
                    Console.ResetColor();
                    Console.Write("Secim edin: ");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Emeliyyat ugurlu oldu");
                        Console.ResetColor();

                    }

                    Console.Clear();
                    Console.WriteLine("[1] Kredit goturmek");
                    Console.WriteLine("[2] Kredit odemek");
                    Console.WriteLine("[3] Hesabat");

                    Console.Write("Seciminizi daxil edin: ");

                    secim = int.Parse(Console.ReadLine());

                    if (secim == 2)
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"Ayliq odenis : ");
                        Console.ResetColor();
                        odenis = umumi_mebleg / month;
                        Console.WriteLine(odenis);
                        Console.Write("Odenis etmek ucun [1] click edin: ");
                        int click = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Odenis ugurlu oldu ");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Qalan borc: ");
                        Console.ResetColor();
                        borc = umumi_mebleg - odenis;
                        Console.WriteLine(borc);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Qalan ay: ");
                        Console.ResetColor();
                        qalan_ay = month - 1;
                        Console.WriteLine(qalan_ay);

                    }




                }

                Console.WriteLine();
                Console.WriteLine("[1] Kredit goturmek");
                Console.WriteLine("[2] Kredit odemek");
                Console.WriteLine("[3] Hesabat");

                Console.Write("Seciminizi daxil edin: ");

                secim = int.Parse(Console.ReadLine());
                Console.Clear();
                if (secim == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Umumi odenilecek mebleg: ");
                    Console.ResetColor();
                    Console.WriteLine(umumi_mebleg);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Qalan ay: ");
                    Console.ResetColor();
                    Console.WriteLine(qalan_ay);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Ayliq odenis: ");
                    Console.ResetColor();
                    Console.WriteLine(odenis);
                }

            }
        }
    }
}
