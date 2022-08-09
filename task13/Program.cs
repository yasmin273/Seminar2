﻿
/// Пробует взять третью цифру из входного числа в виде строки.

bool TryParseThirdDigit(string num, out int result)
{
    result = default;
    if (num.Length < 3)
        return false;

    result = int.Parse(
        num.ElementAt(2) 
    ); 

    return true;
}

Console.Write("Введите число: ");
var num = Console.ReadLine();

if (TryParseThirdDigit(num, out int thirdDigit))
    Console.WriteLine($"{num} -> {thirdDigit}");
else
    Console.WriteLine($"{num} -> третьей цифры нет");