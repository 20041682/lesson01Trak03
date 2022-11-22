//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
 int number = 18;

 int odd = number % 2;

 if (odd != 0)
{
Console.WriteLine (odd);
}
    else
{
    Console.WriteLine ("является четным");
}