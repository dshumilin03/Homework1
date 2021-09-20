using System;
class exercise2 {

    /* Дан массив действительных чисел, среди которых есть равные.
     * Найти первый максимальный элемент массива и заменить его нулём. */

    static void Main() 
    {
        Console.WriteLine("Введите множество действительных чисел через пробел: ");
        int index = 0; // последующий индекс наибольшего первого элемента

        String[] numbersString = Console.ReadLine().Split(' '); // ввод в 1 строку всех чисел, они будут записаны с типом String

        double[] numbers = new double[numbersString.Length]; // объявляю массив типа double размером
                                                             // как массив numbersString (размер можно получить с помощью метода ИМЯ.Length)

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(numbersString[i]); // прохожусь по всем элементам numbersString,
                                                             // меняю их тип на double и записываю в массив numbers
        }

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[index] < numbers[i]) // т.к. index = 0, то есть индекс наибольшего первого 0 (пока что так т.к. мы не знаем на каком
                                             // месте он будет, то нам не нужно идти с первого элемента массива, ведь мы сравниваем
                                             // в цикле for элемент numbers с индексом "index"(переменная несет в себе число) с numbers с
                                             // индексом i (то есть мы смотрим, если текущий элемент больше максимального, то мы заменяем значение
                                             // index на значение i, получая в итоге первый максимальный элемент
            {
                index = i;

            }
        }
        numbers[index] = 0; // меняем первый наибольший элемент на 0
        Console.WriteLine("__________________________");
        Console.WriteLine();
        foreach (int i in numbers)
        {
            Console.Write(i + " "); // вывыдим массив
        }

    }

}