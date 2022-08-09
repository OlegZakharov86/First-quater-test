// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам

namespace Test
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Начальный масиив: ");
            string[] startMas = { "program", "test", "analyst", "project", "product", "5" };
            int position = 0;
            while (position < startMas.Length)
            {
                Console.Write($"{startMas[position]} ");
                position++;
            }
            Console.WriteLine();
            string[] resultMas = new string[startMas.Length];
            int index = 0;
            for(int i = 0; i < startMas.Length; i++)
            {
                if(startMas[i].Length <=3)
                {
                    resultMas[index] = startMas[i];
                    index++;
                }
            }
            Console.WriteLine("Конечный масcив: ");
            int pos = 0;
            while (pos < resultMas.Length)
            {
                Console.Write($"{resultMas[pos]} ");
                pos++;
            }
        }
    }
}

