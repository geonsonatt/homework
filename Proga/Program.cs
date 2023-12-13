using System;
using System.IO.Compression;
using Microsoft.VisualBasic;
namespace Math
    {
        class Program 
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Ввод числа на отрезке [10,99]:" );
                int number = Convert.ToInt32(Console.ReadLine());
                if ( number < 10 || number > 99 )
                {
                Console.WriteLine("ERROR:Выход за пределы отрезка");
                }
                else
                {
                int firstdigit = number / 10;
                int seconddigit = number % 10; 
                int maxdigit = firstdigit > seconddigit ? firstdigit : seconddigit;
                Console.WriteLine(maxdigit);
                }   
            }
        }
    }
/*Добавлен апдейт в виде ошибки в случае выхода за пределы заданного отрезка       
    