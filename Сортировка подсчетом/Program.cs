//Сортировка методом подсчета

int[] array = { 2, 1, 2, 3, 2, 3 };
int[] count = new int[array.Length];

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

//сортировака отсортированных элементов в исходном массиве 
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

//вывод отсортированых элементов
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");
}