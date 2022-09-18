string[] text = { "Решение 1: простой вывод в консоль.", "Решение 2: запись в другой массив" };
Console.Write("Выберите решение: {0} : ", string.Join(" ", text));
int x = Convert.ToInt32(Console.ReadLine());
if (x > 2) Console.WriteLine("ERROR Вы не выбрали задачу.");
if (x < 1) Console.WriteLine("ERROR Вы не выбрали задачу.");
if (x == 1)
{
    string[] array = { "nem", "hello", "234", "people", "LoL" };
    Console.Write("[{0}]->", string.Join(",", array));
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) Console.Write(array[i] + ",");
    }
    Console.Write("]");
}
if (x == 2)
{
    string[] array = { "nem", "hello", "234", "people", "LoL" };
    Console.Write("[{0}]->", string.Join(",", array));
    string[] array2 = new string[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Array.Resize(ref array2, array2.Length + 1);
            array2[array2.Length - 1] = array[i];
            
        }
    }
    Console.Write("[{0}]", string.Join(",", array2));
}