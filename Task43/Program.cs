//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double GetVariable(string varName)
{
   Console.WriteLine($"Введите {varName}:");
   int currentVar = Convert.ToInt32(Console.ReadLine());
   return currentVar;
}

Console.WriteLine("Найдём точку пересечения двух прямых,");
Console.WriteLine("Заданных уравнениями:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");
Console.WriteLine("Введите значения b1, k1, b2 и k2");
double b1 = GetVariable("b1");
double k1 = GetVariable("k1");
double b2 = GetVariable("b2");
double k2 = GetVariable("k2");
//k1*x + b1 = k2*x + b2
//k1*x - k2*x = b2 - b1
//(k1-k2)*x = b2 - b1
double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x}; {y})");



