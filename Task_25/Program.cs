int Prompt (string message)
{
    Console.Write(message);
    string readInput = Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

int Power (int powerBase, int exponent)
{
    int power = 1;
    for (int i = 0; i < exponent; i++)
    {
        power = power * powerBase;
    }
    return power;
}

bool ValideteExponent(int exponent)
{
    if (exponent < 0)
    {
        Console.WriteLine("Показатель не должен быть меньше нуля");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите число возводимое в степень: ");
int exponent = Prompt("Введите число степени: ");
if (ValideteExponent(exponent))
{
    Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}
