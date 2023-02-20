Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}
 int PozitiveNum(int[] array)
 {

    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
        {
            result++;
        }
    }
    return result;
 }
 Console.WriteLine("Введите M чисел: ");
 int size = int.Parse(Console.ReadLine()!);
 int[] array = GetArray(size, -2, 8);
int result = PozitiveNum(array);
 Console.Write(String.Join(",", array));
 Console.Write($" ->  {result} ");