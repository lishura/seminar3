Console.WriteLine("Введите пятизначное число");
int x = Math.Abs(int.Parse(Console.ReadLine()));

bool IsPalindrom(int x)
{
    if (x % 100 / 10 == x % 10000 / 1000 && x % 10 == x % 100000 / 10000)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.WriteLine(IsPalindrom(x));