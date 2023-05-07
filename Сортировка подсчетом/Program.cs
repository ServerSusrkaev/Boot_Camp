//Сортировка методом подсчета

int[] array = {0, 2, 3, 2, 13};
int max = array.Max();
int[] count = new int[max + 1];

// for (int i = 0; i < count.Length; i++)
// {
//     System.Console.Write($"{count[i]}");
// }

//System.Console.Write(array.Max());

//Определение количества повторяющихся элементов в исходном массиве array[]
// внесение их во вспомогателный массив caount[]
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
    count[array[i]]++;
}
Console.WriteLine("");
for (int i = 0; i < count.Length; i++)
{
    Console.Write($"{count[i]} ");
}

// //сортировака отсортированных элементов в исходном массиве 
Console.WriteLine("");
int k = 0;
for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < count[i]; j++)
    {
        array[k] = i;
        k++;
    }
}
System.Console.WriteLine(" ");
Console.Write(string.Join(", ", array));