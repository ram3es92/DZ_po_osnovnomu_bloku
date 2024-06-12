class Program
{
    static void Main()
    {
        // Исходный массив строк. Раскомменитровать нужный пример.
        // string[] initialArray = { "Hello", "2", "world", ":-)" };
        string[] initialArray = { "1234", "1567", "-2", "computer science" };
        // string[] initialArray = { "Russia", "Denmark", "Kazan" };

        // Подсчет количества строк длиной <= 3 символа
        int count = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива необходимого размера
        string[] resultArray = new string[count];

        // Заполнение нового массива подходящими строками
        int index = 0;
        for (int i = 0; i < initialArray.Length; i++)
        {
            if (initialArray[i].Length <= 3)
            {
                resultArray[index] = initialArray[i];
                index++;
            }
        }

        // Вывод результата
        Console.WriteLine("[" + string.Join(", ", resultArray) + "]");
    }
}
