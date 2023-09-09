// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] AnyLength()
{
    int i = 0;
   List<int> line = new List<int>();

    while(true)
    {
        Console.WriteLine($"Choose the {i + 1} digit or press 'q' to quit");
        string input = Console.ReadLine();

        if (input == "q")
        {
            break;
        }
        else if (input != "q")
        {
            int num = Convert.ToInt32(input);
            line.Add(num);
            i++;
        }
    }
    int[] intArray = line.ToArray();
    return intArray;
}

int MoreThenZero(int[] line)
{
    int count = 0;
    for(int i = 0; i < line.Length; i++)
    {
        if (line[i] >= 0)
        count++;
    }
    return count;
}

int[] array = AnyLength();
Console.WriteLine(string.Join(", ", array));

int result = MoreThenZero(array);
Console.WriteLine(result);