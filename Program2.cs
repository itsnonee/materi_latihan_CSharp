using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Latihan_C_
{
    public class Program2
    {
        int c;
        //Program untuk operasi perkalian
        public void Perkalian() { // method perkalian
            Console.WriteLine("Hello, Ini adalah Program2.cs"); // perintah untuk menampilkan teks atau nilai ke consol/output

            var a = 5; // mendeklarasi variable a dengan nilai 5
            var b = 5; // mendeklarasi variable b dengan nilai 5
            c = a * b; // mendeklarasi variable c yang menyimpan nilai dari hasil perkalian dari var a & b
            Console.WriteLine("Hasil perkalian dari " + a + " * " + b + " = " + c); // perintah untuk menampilkan nilai dari var c
        }

        public void Pertambahan(int a, int b) { // method pertambahan
            // perintah untuk menampilkan hasil pertambahan dari parameter a dan b       
            Console.WriteLine("Hasil dari pertambahan " + a + " + " + b + " = " + (a+b) );

            //int result = a + b;
            //Console.Write("Hasil pertambahan dari " + a + " + " + b + " = " + result);
        }
    }
}