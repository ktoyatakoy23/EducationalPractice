using System;
using System.Collections.Generic;
using System.Linq;

Random rand = new Random();
    int[,] gamefield = new int[4, 4];
    List<int> UsedNumbers = new List<int>();    

    for (int i = 0; i < gamefield.GetLength(0); i ++) // циклы работают пока выполняется условие
                                                      // (временная переменная меньше чем количество символов в вертикальной строке, а потом в горизантальной (чаще))
    {
        for(int j = 0; j < gamefield.GetLength(1); j++)
        {
            Console.WriteLine("массив создается....");
            int check = rand.Next(1, 17); // первичная генерация чисел для будущей проверки и добавления
        
            while (UsedNumbers.Contains(check)) //проверяет находится ли в списке usednumbers повторяющиеся числа с помощью метода contains
            {
                check = rand.Next(1, 17); // повторная генерация чисел, чтоб совпадало условие while
                                         // (список usednumbers уже полный, ибо первые прогоны оно только только заполнялось и условие было верным)
            }
            gamefield[i, j] = check;//добавление в основной массив проверенных и сгенерированных чисел
            UsedNumbers.Add(check); //добавление в список usednumbers рандомно сгенерированных чисел
        }
            
    }


    Console.WriteLine(" ");

    for (int i = 0; i < gamefield.GetLength(0); i++)
    {
        for (int j = 0; j < gamefield.GetLength(1); j++)
        {
            Console.Write(gamefield[i, j] + " ");// переменные i j отвечают за навигацию на сетке массива ( допустим [1, 4] - выведет четвертое число на первой строке)
        }
        Console.WriteLine(""); //делает перенос строки для отображения в виде сетки
    }

    Console.WriteLine("");

    for (int steps = 1; steps < 20; steps++)
    {
        Console.WriteLine("Введи первое число: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        int column;
        int row = 0;

        for (column = 0; column < gamefield.GetLength(0); column++)
        {
            for (row = 0; row < gamefield.GetLength(1); row++)
            {
                if (firstNumber == gamefield[column, row]) //cравниваем значение от пользователя с элементом основного массива, который вызван двумя циклами for,
                                                           //цикл начинается сначала если условие не выполняется и два вложенных цикла for работают до тех пор пока
                                                           //не совпадет число введенное пользователем с числом в массиве, а что делать если не совпадет совсем я пока не придумал
                {
                    firstNumber = gamefield[column, row]; // заменяем значение от пользователя на то что было в массиве
                    goto next_number;
                }

            }

        }

    next_number:;


        Console.WriteLine("Введи второе число: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        int column1;
        int row1 = 0;

        for (column1 = 0; column1 < gamefield.GetLength(0); column1++)
        {
            for (row1 = 0; row1 < gamefield.GetLength(1); row1++)
            {
                if (secondNumber == gamefield[  column1, row1])
                {
                    secondNumber = gamefield[column1, row1];
                    goto numbersEnd;
                }

            }

        }

    numbersEnd:;

        gamefield[column, row] = secondNumber;
        gamefield[column1, row1] = firstNumber;

        Console.WriteLine(" ");

        for (int i = 0; i < gamefield.GetLength(0); i++)
        {
            for (int j = 0; j < gamefield.GetLength(1); j++)
            {
                Console.Write(gamefield[i, j] + " ");// переменные i j отвечают за навигацию на сетке массива ( допустим [1, 4] - выведет четвертое число на первой строке)
            }
            Console.WriteLine(""); //делает перенос строки для отображения в виде сетки
        }

        Console.WriteLine("");

        Console.WriteLine("Кол-во перемещений - " + steps);



        bool isSorted = true;
        int prevNumber = 0;
        for (int i = 0; i < gamefield.GetLength(0); i++)
        {
            for (int j = 0; j < gamefield.GetLength(1); j++)
            {
                int currentNumber = gamefield[i, j];
                if (currentNumber < prevNumber)
                {
                    isSorted = false;
                    break;
                }
                prevNumber = currentNumber;
            }
            if (!isSorted) break;
        }
        if (isSorted)
        {
            Console.WriteLine("Поздравляем, вы выиграли!");
            return;
        }
}
