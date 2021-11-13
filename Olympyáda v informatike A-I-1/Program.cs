using System;

namespace Olympyáda_v_informatike_A_I_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Premení prvý riadok vstupu na 3 variable n = počet tanečníkov, k = pozícia kráľa, l = max počet krokov
            var input1 = Console.ReadLine();
            int[] hodnoty = Array.ConvertAll(input1.Split(' '), int.Parse);
            int n = hodnoty[0], k = hodnoty[1], l = hodnoty[2];
            



            var input2 = Console.ReadLine();
            int[] tanecnici = Array.ConvertAll(input2.Split(' '), int.Parse);
            int[] zoradenyTanecnici = tanecnici;
            Array.Sort(tanecnici, zoradenyTanecnici);
            foreach (int value in zoradenyTanecnici)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine(TrebaPostup(ref l));
            
            
            
            static Boolean TrebaPostup(ref int l)
            {
                if (l == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }



    }
}
