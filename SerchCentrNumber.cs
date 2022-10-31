int CenterNumber(int num)
{
    int firstValue = num / 100;
    int secondValue = num % 10;
    int result = firstValue * 10 + secondValue;
    return result;
}

int number = new Random().Next(100, 1000);
int num = CenterNumber(number);
Console.WriteLine($"{number} => {num}");