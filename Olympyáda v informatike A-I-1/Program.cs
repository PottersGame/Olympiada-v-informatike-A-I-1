using System;
using System.Collections.Generic;

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
            Console.Clear();
            if (tanecnici[kIndex] == zoradenyTanecnici[kIndex] )
            {
                Console.WriteLine("ANO");
            }
            else if (tanecnici[kIndex] == zoradenyTanecnici[kIndex])
            {
                Console.WriteLine("NIE");
                return;
            }

            
            if (TrebaPostup(ref l) == true)
            {
                List<int> kroky = new List<int>();
                for (int i = 0; i < tanecnici.Length; i++)
                {
                 

                    if (tanecnici[i] != zoradenyTanecnici[i])
                    {
                        int indexZoradenehoI = Array.IndexOf(tanecnici, zoradenyTanecnici[i]);
                        kroky.Add(i+1);
                        kroky.Add(indexZoradenehoI+1);
                        for (int figura = 0; figura <= (indexZoradenehoI - i) / 2; figura++ )
                        {

                            int Temp = tanecnici[i+figura];
                            tanecnici[i+figura] = tanecnici[indexZoradenehoI-figura];
                            tanecnici[indexZoradenehoI - figura] = Temp;

                        }                  
                    }
                    if (tanecnici != zoradenyTanecnici)
                    {
                        continue;
                    }
                }
                int[] arrKroky = kroky.ToArray();
                int pocetKrokov = arrKroky.Length / 2;
                Console.WriteLine(pocetKrokov);

                for (int g = 0; g < pocetKrokov;)
                {
                    
                    int kroky2 = g + 1;

                    Console.WriteLine(string.Format("{0} {1}", kroky[g], kroky[kroky2]));
                    g++;

                }
            }
            
            
            
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
