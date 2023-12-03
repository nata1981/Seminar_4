//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа,
// сумма цифр которого чётная.
   int sum = 0;
            while (true)
            {
                Console.WriteLine("Введите число");
                string input = Console.ReadLine();
                if (input == "q")
                    break;
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        sum += int.Parse(input[i].ToString());
                    }
                    if (sum % 2 == 0)
                        break;
                    else
                        sum = 0;
                        