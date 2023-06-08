using Latihan_C_;
using Game_Dev;

namespace Latihan_C_
{
    
    public class Program1
    {
        public void Running(){
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ini adalah Program1.cs");
            Console.WriteLine("------------------------");

            // Membuat Objek Program2 dari kelas Program2
            Program2 program2 = new Program2();
            program2.Perkalian();
            program2.Pertambahan(5, 5);

            // Membuat Objek Program1 dari kelas Program1
            Program1 program1 = new Program1();
            program1.pengurangan(5, 6);

            // Memanggil Fungsi pembagian
            pembagian(5, 5);
            
        }

         int result;
        public void pengurangan(int a, int b)
        {
            result = a - b;
            Console.WriteLine(result);
        }

        public static void pembagian(int a, int b)
        {
            Console.WriteLine("Ini adalah fungsi pembagian");
            int result = a / b;
            Console.WriteLine(result);
        }
    }
}