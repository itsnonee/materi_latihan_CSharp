using System;

namespace Game_Dev
{
    public class Programmer
    {
        public void Main(string[] args)
        {
            pertemuan_5("Jumat", 9, 4 , "Lab Siber", false, true);
        }

        public static void pertemuan_5(string day, int date, int time, string place ,bool isLappy, bool isPresent)
        {
            if(day == "Jumat" && date == 9 && isPresent == true)
            {
                Console.WriteLine("Jangan lupa ada pertemuan GameDev😎");

                if(time == 4 && place == "Lab Siber")
                {
                    Console.WriteLine("Gasskueenn ke pertemuan GameDev😍");
                    Console.WriteLine("Di Lab Keamanan Siber, Lt 3 yahh gaess");

                    if (isLappy == false)
                    {
                        Console.WriteLine("Jangan lupaa bawa lappy gaess, mau ngoding dlu kita👀");
                    }
                }
            }
            else
            {
                Console.WriteLine("Yahhh😢");
                Console.WriteLine("Semoga pertemuan selanjutnya bolehh join yahh✨");
            }
        }
    }
}
