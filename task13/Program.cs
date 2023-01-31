// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
string s = Console.ReadLine();
if (s.Length < 3){
    Console.WriteLine("Третьей цифры нет");
}
else{
string s2 = Convert.ToString(s[2]);
Console.WriteLine($"Третья цифра: {s2}");
}