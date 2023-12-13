using System;
using System.IO.Compression;
namespace Math
    {
        class Program 
        {
            static void Main(string[] args)
            {
            Console.WriteLine("Введите число N" );
            int N = Convert.ToInt32(Console.ReadLine());
            if (N < 10)
            {
            Console.WriteLine(N);
            }
                else
                {  
                while (N > 0)
                {
                int NewN = N % 10; //Получаем остаток числа, для записи   
                N /= 10;
                    if (N>0)
                    {
                    Console.Write(NewN +",");   
                    }
                    else
                    {
                    Console.WriteLine(NewN);    
                    }   
                }   
                }
                
            }
        }
    }
        
    