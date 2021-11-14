using System;
using System.Collections.Generic;
using System.Linq;

namespace Olympyáda_v_informatike_A_I_1
{
    class Program
    {


        static void Main(string[] args)
        {

            bool executedKrok = false;
            // PremenÃ­ prvÃ½ riadok vstupu na 3 variable n = poÄet taneÄnÃ­kov, k = pozÃ­cia krÃ¡Ä¾a, l = max poÄet krokov
            var input1 = Console.ReadLine();
            int[] hodnoty = Array.ConvertAll(input1.Split(' '), int.Parse);
            int nLength = hodnoty[0] - 1, kIndex = hodnoty[1] - 1, l = hodnoty[2];

            var input2 = Console.ReadLine();
            int[] tanecnici = Array.ConvertAll(input2.Split(' '), int.Parse);
            int[] zoradenyTanecnici = new int[tanecnici.Length];
            Array.Copy(tanecnici, zoradenyTanecnici, tanecnici.Length);
            Array.Sort(zoradenyTanecnici);

            if (tanecnici[kIndex] == zoradenyTanecnici[kIndex])
            {
                int[] kroky = new int[] { };
                for (int i = 0; i <= tanecnici.Length-1; i++)
                {
                    if (i == kIndex && tanecnici[kIndex] != zoradenyTanecnici[kIndex])
                    {

                        NIE();
                        return;
                    }
                    
                    
                    else
                    {
                        if (tanecnici[i] != zoradenyTanecnici[i])
                        {
                            int indexZoradenehoI = Array.IndexOf(tanecnici, zoradenyTanecnici[i]);
                            
                            for (int figura = 0; figura <= (indexZoradenehoI - i) / 2; figura++)
                            {
                                int Temp = tanecnici[i + figura];
                                tanecnici[i + figura] = tanecnici[indexZoradenehoI - figura];
                                tanecnici[indexZoradenehoI - figura] = Temp;

                                executedKrok = true;
                            }
                            if (i < indexZoradenehoI && executedKrok == true)
                            {
                                kroky = kroky.Concat(new int[] { i + 1 }).ToArray();
                                kroky = kroky.Concat(new int[] { indexZoradenehoI + 1 }).ToArray();
                                executedKrok = false;
                            }
                            else if (i > indexZoradenehoI && executedKrok == true)
                            {
                                kroky = kroky.Concat(new int[] { indexZoradenehoI + 1 }).ToArray();
                                kroky = kroky.Concat(new int[] { i + 1 }).ToArray();
                                executedKrok = false;
                            }

                        }
                    }
                    if (tanecnici != zoradenyTanecnici && i == tanecnici.Length)
                    {
                        i = 0;
                    }

                }
                Console.Clear();
                Console.WriteLine("ANO");
                if (l != 0)
                {
                    int pocetKrokov = kroky.Length;
                    Console.WriteLine(pocetKrokov / 2);

                    for (int g = 0; g < pocetKrokov; g += 2)
                    {

                        int kroky2 = g + 1;
                        Console.WriteLine(string.Format("{0} {1}", kroky[g], kroky[kroky2]));


                    }


                }
            }
            else
            {
                Console.Clear();
                NIE();
            }


        }

        static void NIE()
        {
            Console.WriteLine("NIE");
        }


    }
}
