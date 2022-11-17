int dayNum = ReadInt("Введите число дня недели:");
if ((dayNum < 1) || (dayNum > 7))

    Console.WriteLine("Введите число от 1 до 7");

else
{

if (dayNum<=5)

Console.WriteLine("Рабочий день");

else

Console.WriteLine("Выходной");
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

