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
            int nLength = hodnoty[0] - 1, kIndex = hodnoty[1] - 1, l = hodnoty[2];

            var input2 = Console.ReadLine();
            int[] tanecnici = Array.ConvertAll(input2.Split(' '), int.Parse);
            int[] zoradenyTanecnici = new int[tanecnici.Length];
            Array.Copy(tanecnici, zoradenyTanecnici, tanecnici.Length);
            Array.Sort(zoradenyTanecnici);
            if ((Array.IndexOf(zoradenyTanecnici, tanecnici[kIndex])) == kIndex)
            {
                Console.WriteLine("ANO");
            }
            else if ((Array.IndexOf(zoradenyTanecnici, tanecnici[kIndex])) != kIndex)
            {
                Console.WriteLine("NIE");
                return;
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
