void fillarray(int[] array, int min, int max)
{
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(min, max + 1);
    }
}

void printarray(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
       Console.Write(array[i] + ", ");
    }
     Console.Write(array[array.Length - 1] + ". ");
     Console.WriteLine();
}

int findsum(int[] array)
{
    int result = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}
Random rand = new Random();
int[] array = new int[rand.Next(4, 10)];
fillarray(array, 1, 50);
printarray(array);
Console.WriteLine(findsum(array));