// Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

    Random rnd = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(100, 999);
            }
            int count = 0;
            foreach (var item in array)
            {
                if (item % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"Чётных чисел в массиве: {count}");
            Console.ReadKey();
        