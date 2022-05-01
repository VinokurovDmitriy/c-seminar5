int[] array = {1, 2, 3, 4, 5};
int[] array2 = {10, 20, 30, 40, 50, 60};

void printArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void revertArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[^(i + 1)];
        array[^(i + 1)] = temp;
    }
}

printArray(array);
revertArray(array);
printArray(array);
printArray(array2);
revertArray(array2);
printArray(array2);