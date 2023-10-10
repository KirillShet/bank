using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Program2
    {
        static void Main()
        {
            Bank[] bank = new Bank[5];
            int kol = 0;
            int osh1 = 0;
            int var = 0;
            int x = 0;
            int a = 0;
            int b = 0;
            int osh = 0;
            while (true)
            {
                Console.WriteLine("Добро пожаловать в банк 'Карусель'.");
                Console.WriteLine("Если вы хотите открыть счет, то введите цифру 1.");
                Console.WriteLine("Если вы хотите получить информацию конкретного счета, то введите 2.");
                Console.WriteLine("Если вы хотите пополнить какой-то счет, то введите 3.");
                Console.WriteLine("Если вы хотите снять деньги с какого-то счета, то введите 4.");
                Console.WriteLine("Если вы хотите снять все деьнги со счета, то введите 5.");
                Console.WriteLine("Если вы хотите перевести сумму денег с одного счета на другой, то введите 6.");
                var = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (var == 1)
                {
                    bank[0] = new Bank();
                    bank[0].otk();
                    for (int i = 1; i < bank.Length; i++) 
                    {
                        do
                        {
                            osh = 0;
                            bank[i] = new Bank();
                            bank[i].otk();
                            kol++;
                                if (bank[i - 1].nom_chet() == bank[i].nom_chet())
                                {
                                    Console.WriteLine("Такой номер уже есть");
                                    osh++;
                                }
                        } while (osh == 1);
                    }
                }
                else if (var == 2)
                {
                    if (kol == 0)
                    {
                        Console.WriteLine("На данный момент счетов нет.");
                    }
                    else
                    {
                        Console.WriteLine("Какой счет вы хотите вывести: ");
                        var = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < bank.Length; i++)
                        {
                            if (var == bank[i].nom_chet())
                            {
                                bank[i].out_inf();
                            }
                        }
                    }
                }
                else if (var == 3)
                {
                    if (kol == 0)
                    {
                        Console.WriteLine("На данный момент счетов нет.");
                    }
                    else
                    {
                        Console.WriteLine("Какой счет вы хотите вывести: ");
                        var = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < bank.Length; i++)
                        {
                            if (var == bank[i].nom_chet())
                            {
                                bank[i].dob();
                            }
                        }
                    }
                }
                else if (var == 4)
                {
                    if (kol == 0)
                    {
                        Console.WriteLine("На данный момент счетов нет.");
                    }
                    else
                    {
                        Console.WriteLine("Какой счет вы хотите вывести: ");
                        var = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < bank.Length; i++)
                        {
                            if (var == bank[i].nom_chet())
                            {
                                bank[i].umen();
                            }
                        }
                    }
                }
                else if (var == 5)
                {
                    if (kol == 0)
                    {
                        Console.WriteLine("На данный момент счетов нет.");
                    }
                    else
                    {
                        Console.WriteLine("Какой счет вы хотите вывести: ");
                        var = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < bank.Length; i++)
                        {
                            if (var == bank[i].nom_chet())
                            {
                                bank[i].obnul();
                            }
                        }
                    }
                }
                else if (var == 6)
                {
                    if (kol == 0)
                    {
                        Console.WriteLine("На данный момент счетов нет.");
                    }
                    else if (kol == 1)
                    {
                        Console.WriteLine("Недостаточно счетов");
                    }
                    else
                    {
                        do
                        {
                            osh = 0;
                            bank[0].perenos();
                            for (int c = 0; c < bank.Length; c++)
                            {
                                if (bank[c].nom_chet() == bank[0].num_chet2())
                                {
                                    b = c;
                                }
                                else
                                {
                                    osh++;
                                }
                                
                            }
                            if (osh == 4)
                            {
                                osh = 0;
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели неправильное число.");
                                osh++;
                            }
                            for (int i = 0; i < bank.Length; i++)
                            {
                                if (bank[i].nom_chet() == bank[0].num_chet1())
                                {
                                    a = i;
                                }
                                else
                                {
                                    osh++;
                                }
                            }
                            if (osh == 4)
                            {
                                osh = 0;
                            }
                            else
                            {
                                Console.WriteLine("Вы ввели неправильный номер счета.");
                                osh++;
                            }
                        } while (osh > 0);

                        if (b == 0)
                            {
                                osh++;
                            }
                        
                        osh1 = 0;
                            do
                            {
                                osh1 = 0;
                                bank[a].perev();
                                if (bank[a].sum() < bank[a].perev())
                                {
                                    Console.WriteLine("На счету нет таких денег.");
                                    osh1++;
                                }
                            } while (osh1 > 0);
                            bank[b].perev();
                            bank[a].schet1();                            
                            bank[a].posle_schet1();
                            bank[a].out_inf();
                            bank[b].schet2();
                            bank[b].posle_schet2();
                            bank[b].out_inf();
                    }
                }
            }
        }
    }
}
