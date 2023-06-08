using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Latihan_C_;

namespace Belajar_Ngoding
{
    // Ini adalah class ForRunning, class ini digunakan untuk membungkus method Main yang berfungsi untuk menjalankan program
    public class ForRunning
    {
        // Method Main atau Entry Point -- Digunakan untuk menjalankan semua program
        public static void Main(string[] args)
        {
            /*
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Hallo, dah siap belajar ngoding gak?👀");
            Console.WriteLine("Ini adalah method main yang berada di Main.cs, yang akan menjalankan semua program");
            Console.WriteLine("-----------------------------------------------------------------------------------");

            // Variabel dan Tipe Data
            string name = "Del";
            int age = 20;
            double money = 12345678901234567;
            float money2 = 12345678901234567f;
            bool isTaken = true;
            char grade = 'S';

            Console.WriteLine("Nama : " + name);
            Console.WriteLine("Umur : " + age);
            Console.WriteLine("Saldo : " + money);
            Console.WriteLine("Pengeluaran : " + money2);
            Console.WriteLine("Status : " + isTaken);
            Console.WriteLine("Nilai : " + grade);
            Console.WriteLine("-----------------------------------------------------------------------------------");
            
            // Percabangan
            if (name != "Del")
            {
                Console.WriteLine("Kamu siapa?");
            }
            else
            {
                Console.WriteLine("Ya, saya Del");
            }

            if (money <= 500000)
            {
                Console.WriteLine("Misskuenn");
            }
            else
            {
                Console.WriteLine("YTTA");
            }

            if (age >= 20 && isTaken != true)
            {
                Console.WriteLine("Yahhh, dah gede masih jomblo :'D");
            }
            else
            {
                Console.WriteLine("Yee masih kecill so batona");
            }

            */
            // Perulangan
            int rows = 5;
            
            // segitiga siku-siku
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // segitiga piramida
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            /*
            Console.WriteLine("Masukkan jumlah joke yang ingin ditampilkan : ");
            int jumlahJoke = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < jumlahJoke; i++)
            {
                Console.WriteLine("Joke " + (i+1) + ":");
                Console.WriteLine("Knock Knock! ");

                Console.Write("Who's there? ");
                string response = Console.ReadLine() ?? string.Empty;

                Console.WriteLine(response + " who?");
                string punchline = Console.ReadLine() ?? string.Empty;

                Console.WriteLine("-------------------------------");
            }
            */
        }
    }
}