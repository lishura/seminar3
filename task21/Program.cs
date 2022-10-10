double PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    double value = double.Parse(input);
    return value;
}

double xa = PrintAndGetValue("Введите координату х для точки А");
double ya = PrintAndGetValue("Введите координату y для точки А");
double za = PrintAndGetValue("Введите координату z для точки А");
double xb = PrintAndGetValue("Введите координату х для точки B");
double yb = PrintAndGetValue("Введите координату y для точки B");
double zb = PrintAndGetValue("Введите координату z для точки B");


double s = Math.Sqrt((Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2) + Math.Pow((za - zb), 2)));

Console.WriteLine(s);