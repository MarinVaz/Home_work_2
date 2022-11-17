int num1 = ReadInt("Введите число:");

if (ThirdDigit(num1) == -1)
Console.WriteLine("третьей цифры нет");
else
Console.WriteLine($"Третье число: {ThirdDigit(num1)}");

int ThirdDigit(int num1)
    {
        int result = -1;
            if (num1 >= 100)
            {
                while (num1 > 999)
                {
                    num1 = num1 / 10;
                }
                result = num1 % 10;
            }
            return result; 
    }

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}