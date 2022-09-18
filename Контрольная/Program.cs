string[] text = { "Решение 1: простой вывод в консоль.", "Решение 2: запись в другой массив" };
Console.Write("Выберите решение: {0} :", string.Join(" ", text));
int x = Convert.ToInt32(Console.ReadLine());
if (x > 2) Console.WriteLine("ERROR Вы не выбрали задачу.");
if (x < 1) Console.WriteLine("ERROR Вы не выбрали задачу.");