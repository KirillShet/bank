using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Bank
    {
        private int nom_schet;
        public string fio;
        public float summa;
        public float dobav;
        public float minus;
        public float perevod;
        public int nom_schet1;
        public int nom_schet2;
        public float summa1;
        public float summa2;
        public float bodr;
        public float bodr1;
        /*public int */
        public void otk()
        {
            Console.WriteLine("Введите номер счета: ");
            nom_schet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца счета: ");
            fio = Console.ReadLine();
            Console.WriteLine("Введите сумму счета: ");
            summa = float.Parse(Console.ReadLine());
            perevod = 0;
            Console.Clear();
        }
        public void out_inf()
        {
            Console.WriteLine("Номер счета: " + nom_schet);
            Console.WriteLine("ФИО владельца счета: " + fio);
            Console.WriteLine("Введите сумму счета: " + summa);
        }
        public int nom_chet()
        {
            return nom_schet;
        }
        public float sum()
        {
            return summa;
        }
        public void dob() 
        {
            Console.WriteLine("Введите количество денег, которое вы хотите положить на счет: ");
            dobav = float.Parse(Console.ReadLine());
            summa += dobav;
            Console.WriteLine("Было добавлено на счет: " + dobav + ", теперь на счета: " + summa);
        }
        public void umen()
        {
            Console.WriteLine("Введите количество денег, которое вы хотите снять со счет: ");
            minus = float.Parse(Console.ReadLine());
            if (minus > summa)
            {
                Console.WriteLine("Введенное число больше, чем количество денег на счете.");
            }
            else
            {
                summa -= minus;
                Console.WriteLine("Было снято со счет: " + minus + ", теперь на счета: " + summa);
            }
        }
        public void obnul() 
        {
            Console.WriteLine("Введется обнуление всего счета...");
            summa -= summa;
            Console.WriteLine("Теперь на счету: " + summa);
        }
        public void perenos()
        {
            Console.WriteLine("С какого счета вы хотите перевести деньги?");
            nom_schet1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("На какой счет вы хотите перевести деньги?");
            nom_schet2 = Convert.ToInt32(Console.ReadLine());
        }
        public int num_chet1()
        {
            return nom_schet1;
        }
        public int num_chet2()
        {
            return nom_schet2;
        }
        public float perev()
        {
            Console.WriteLine("Сколько вы хотите перевести?");
            perevod = float.Parse(Console.ReadLine());
            return perevod;
        }
        public void schet1()
        {
            bodr = perevod;
            summa1 = summa;
            summa1 = summa1 - bodr;
            Console.WriteLine("На счете под номером: " + nom_chet() + " осталось всего: " + summa1);
        }
        public void schet2()
        {
            bodr1 = perevod;
            summa2 = summa;
            summa2 += bodr1;
            Console.WriteLine("На счете под номером: " + nom_chet() + " осталось всего: " + summa2);
        }
        public void posle_schet1()
        {
            summa = summa1;
        }
        public void posle_schet2()
        {
            summa = summa2;
        }
    }
}
