using System; 
    namespace Math
    {
        class Program 
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите число" );
                int n1 = Convert.ToInt32(Console.ReadLine());
                if (n1 % 7 == 0)
                {
                Console.WriteLine($"{n1} Кратно 7");
                }
                else  
                {
                Console.WriteLine($"{n1} не кратно 7");
                }
                
                if (n1 % 23 == 0)
                {
                Console.WriteLine($"{n1} кратно 23");
                }
                else  
                {
                Console.WriteLine($"{n1} не кратно 23");
                }
                
                
            }
            
        }
    }