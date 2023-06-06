using Latihan_C_;

namespace Latihan_C_
{
    
    public class Program1
    {
        int result;
        public void pengurangan(int a, int b)
        {
            result = a - b;
            Console.WriteLine(result);
        }

        
        //Kalau mo pangge function dari file references, di main hrus pke static sedangkan di file references nd perlu
        public static void Main(string[] args){
            Console.WriteLine("Hello World!");
            Console.WriteLine("Ini adalah Program1.cs");
            Console.WriteLine("------------------------");

            Program2 program2 = new Program2();
            program2.Perkalian();
            program2.Pertambahan(5, 5);

            Program1 program1 = new Program1();
            program1.pengurangan(5, 6);
            
        }

        
        
    }
}