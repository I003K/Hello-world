using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            string exampleString = "Hello World";
            int exampleInt = 50; //4 bytes 1111111 + 1 = 1 00000000
            float exampleFloat = 50.5f; //4 bytes мантисса (500) + порядок (-1)
            double exampleDouble = 50.5; //8 bytes
            short exampleShort = 50; //2 bytes
            long exampleLong = 50; //8 bytes

            bool exampleBoolean = true; // true / false
            char exampleCharacter = 'n'; // только один символ
            char[] exampleCharacters = { 'f', 'e', 'q' };

            string[] hellos = { "Hallo", "Hello", "Salve", "Ciao" };
            Console.WriteLine(hellos[0]); //Hallo
            Console.WriteLine(hellos[3]); //Ciao

            Console.WriteLine(exampleString);

            //for
            //while
            //foreach

            //for (int i = 0; i < exampleInt; i++)
            int i = 0;
            foreach (string hello in hellos)
            {

                Console.WriteLine(hello);
                i++;
                Console.WriteLine("Вы продолжили " + i + " время.");
            }

            Console.WriteLine("Введите символ");
            exampleCharacter = Console.ReadLine()[0];

            switch(exampleCharacter)
            {
                case 'n':
                    Console.WriteLine("это N");
                    break;

                case 'q':
                    Console.WriteLine("это Q");
                    break;

                default:
                    Console.WriteLine("этого символа нету среди избранных");
                    break;


            }
                //Конкантенация == сложение строк

                /*
                if (Console.ReadKey().Key == ConsoleKey.N)
                {
                    Console.WriteLine("\nВы продолжили.");
                    Console.ReadKey();


                }
                else
                {
                    Console.WriteLine("\nВремя остановиться.");
                    Console.ReadKey();
                }
                */
            
        }
    }
}
