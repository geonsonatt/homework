using System; 
    namespace Math
    {
        class Program 
        {
            static void Main(string[] args)
            {
                Console.WriteLine("введите координату X" );
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("введите координату Y" );
                int n2 = Convert.ToInt32(Console.ReadLine());
                if (n1 == 0 && n2 == 0)
                {
                Console.WriteLine("Точка координат введена неверно");
                }
                else  
                if (n1 > 0 && n2 > 0)
                {
                Console.WriteLine("Точка координат находится в 1 четверти");
                }
                else if (n1 < 0 && n2 > 0)
                {
                Console.WriteLine("Точка координат находится во 2 четверти");
                }
                else 
                    if (n1 < 0 && n2 < 0)
                {
                Console.WriteLine("Точка координат находится в 3 четверти");
                }
                else  
                {
                Console.WriteLine("Точка координат находится в 4 четверти");
                }
                
            }
            
        }
    }