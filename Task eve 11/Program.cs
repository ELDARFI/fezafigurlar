using System;
using Task_eve_11.Fiqurlar;

namespace Task_eve_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Konus k = new Konus(5, 10, 3);
            Silindir s = new Silindir(10, 10, 3);
            duzbucaqliparalepiped d = new duzbucaqliparalepiped(5, 3, 4);

            Console.WriteLine($"Duzbucaqli paralepipedin tam sethinin sahesi: {d.STam()}"); 
            Console.WriteLine($"Duzbucaqli paralepipedin tam sethinin sahesi: {d.Hecmi()}");

            Console.WriteLine($"Konusun oturacaginin sahesi: {k.Oturacaqsahesi()}");
            Console.WriteLine($"Konusun hecmi: {k.Hecmi()}");
            Console.WriteLine($"Konusun tam sethinin sahesi: {k.Tamsethininsahesi()}");

            Console.WriteLine($"Silindirin oturacaginin sahesi: {s.Oturacaqsahesi()}");
            Console.WriteLine($"Silindirin hecmi: {s.Hecmi()}");
            Console.WriteLine($"Silindirin tam sethinin sahesi: {s.Silindirinsahesi()}");



        }
    }
}
