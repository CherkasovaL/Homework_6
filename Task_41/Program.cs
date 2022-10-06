// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write($"Введите количество чисел: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] ArrayNumbers = new int[a];
void Numbers(int a)
{
for (int i = 0; i < a; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    ArrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}
int Comparison(int[] ArrayNumbers)
{
  int count = 0;
  for (int i = 0; i < ArrayNumbers.Length; i++)
  {
    if(ArrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}
Numbers(a);
Console.WriteLine($"Чисел больше 0: {Comparison(ArrayNumbers)} ");
