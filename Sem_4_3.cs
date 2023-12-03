// Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.)


  Console.WriteLine("Введите количество элементов в массиве");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите элемент с индексом {i}");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }