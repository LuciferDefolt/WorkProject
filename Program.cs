using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open the file to read
            string path = @"C:\Users\Devold\Desktop\Project\NetDevTest.txt";
            string[] readText = File.ReadAllLines(path);
            int size = 0;

            //Узнаем колличество строк

            foreach (string s in readText)
            {
                size++;
            }

            //Создание массива строк

            string[] TextMas = new string[size];
            int localvariable = 0;

            foreach (string s in readText)
            {
                TextMas[localvariable] = s;
                localvariable++;
            }

            int cdsCount = 0;
            double pricesSum = 0;
            int minYear = 0, maxYear = 0;

            for (int i = 0; i < size; i++)
            {

                //Console.WriteLine(TextMas[i]);

                char[] TextChar = TextMas[i].ToCharArray();
                for (int j = 0; j < TextChar.Length; j++)
                {

                    //Считаем колличество людей

                    if (TextChar[j] == '/')
                    {
                        if (TextChar[j + 1] == 'C')
                        {
                            if (TextChar[j + 2] == 'D')
                            {
                                cdsCount++;
                            }
                        }
                    }
                }
            }

            double[] doublemas = new double[cdsCount];
            int localdoublevariable = 0;
            for (int i = 0; i < size; i++)
            {
                char[] TextChar = TextMas[i].ToCharArray();
                for (int j = 0; j < TextChar.Length; j++)
                {
                    //Считаем сумму
                    if (TextChar[j] == '<')
                    {
                        if (TextChar[j + 1] == 'P')
                        {
                            if (TextChar[j + 2] == 'R')
                            {
                                if (TextChar[j + 3] == 'I')
                                {
                                    if (TextChar[j + 4] == 'C')
                                    {
                                        if (TextChar[j + 5] == 'E')
                                        {
                                            if (TextChar[j + 6] == '>')
                                            {
                                                char[] localtextvariable = new Char[TextChar.Length - 15];
                                                for (int z = 7, f = 0; z <= TextChar.Length - 9; z++, f++)
                                                {
                                                    localtextvariable[f] = TextChar[z];
                                                }
                                                string localstringvariable = new string(localtextvariable);
                                                //pricesSum += Convert.ToDouble(localstringvariable);
                                                doublemas[localdoublevariable] = double.Parse(localstringvariable);
                                                localdoublevariable++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < cdsCount; i++)
            {
                pricesSum += doublemas[i];
            }

            //Ищем страны
            string[] countriesnew = new string[cdsCount];
            for (int i = 0; i < cdsCount; i++)
            {
                countriesnew[i] = " ";
            }
            int localcount = 0;
            for (int i = 0; i < size; i++)
            {
                char[] TextChar = TextMas[i].ToCharArray();
                for (int j = 0; j < TextChar.Length; j++)
                {
                    if (TextChar[j] == '<')
                    {
                        if (TextChar[j + 1] == 'C')
                        {
                            if (TextChar[j + 2] == 'O')
                            {
                                if (TextChar[j + 3] == 'U')
                                {
                                    if (TextChar[j + 4] == 'N')
                                    {
                                        if (TextChar[j + 5] == 'T')
                                        {
                                            if (TextChar[j + 6] == 'R')
                                            {
                                                if (TextChar[j + 7] == 'Y')
                                                {
                                                    if (TextChar[j + 8] == '>')
                                                    {
                                                        char[] localtextvariable = new Char[TextChar.Length - 19];
                                                        for (int z = 9, f = 0; z <= TextChar.Length - 11; z++, f++)
                                                        {
                                                            localtextvariable[f] = TextChar[z];
                                                        }

                                                        countriesnew[localcount] = new string(localtextvariable);
                                                        localcount++;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            int localYearVariable = 0;
            int[] mas = new int[cdsCount];
            for (int i = 0; i < size; i++)
            {
                char[] TextChar = TextMas[i].ToCharArray();
                for (int j = 0; j < TextChar.Length; j++)
                {
                    if (TextChar[j] == '<')
                    {
                        if (TextChar[j + 1] == 'Y')
                        {
                            if (TextChar[j + 2] == 'E')
                            {
                                if (TextChar[j + 3] == 'A')
                                {
                                    if (TextChar[j + 4] == 'R')
                                    {
                                        if (TextChar[j + 5] == '>')
                                        {
                                            char[] localtextvariable = new Char[TextChar.Length - 13];
                                            for (int z = 6, f = 0; z <= TextChar.Length - 8; z++, f++)
                                            {
                                                localtextvariable[f] = TextChar[z];
                                            }

                                            mas[localYearVariable] = Convert.ToInt32(new string(localtextvariable));

                                            localYearVariable++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }




            Console.WriteLine("cdsCount -> " + cdsCount);
            Console.WriteLine("pricesSUM -> " + pricesSum);

            //подчистка
            for (int i = 0; i < cdsCount; i++)
            {
                for (int j = i + 1; j < cdsCount; j++)
                {
                    if (countriesnew[i] == countriesnew[j])
                    {
                        countriesnew[j] = " ";
                    }
                }
            }
            Console.Write("Countries -> ");
            for (int i = 0; i < cdsCount; i++)
            {
                if (countriesnew[i] == " ")
                {

                }
                else
                {
                    Console.Write(countriesnew[i] + " ");
                }
            }
            Console.WriteLine();

            minYear = mas[0];
            maxYear = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (minYear > mas[i])
                {
                    minYear = mas[i];
                }
                if (maxYear < mas[i])
                {
                    maxYear = mas[i];
                }
            }
            Console.WriteLine("Min Year -> " + minYear);
            Console.WriteLine("Max Year -> " + maxYear);

            //Console.WriteLine(minYear);Console.WriteLine(maxYear);

            Console.ReadLine();
        }
    }
}
