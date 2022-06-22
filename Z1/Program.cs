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
}

int findeven(int[] array)
{
    int result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2==0) result++;
    }
    return result;
}

int[] array = new int[5];
fillarray(array, 100, 999);
printarray(array);
Console.WriteLine("\n" + findeven(array));
