int num1 = ReadInt("Введите число:");
int dig1 = num1/10;
int dig2 = dig1%10;
Console.WriteLine(dig2);

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}