int RemoveSecondDigitNumber(int num) => (num / 100) * 10 + (num % 10); 
int GetRandomNumber(int min = 111, int max = 999)
{
    var random = new Random();
    return random.Next(min, max);
}

var num = GetRandomNumber();

Console.WriteLine($"{num} -> {RemoveSecondDigitNumber(num)}");