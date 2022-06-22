void fillarray(double[] array, double min, double max)
{
    Random rand = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rand.NextDouble();
    }
}

void printarray(double[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
       Console.Write(array[i] + ", ");
    }
     Console.Write(array[array.Length - 1] + ". ");
}

double findmax(double[] array)
{
    double max = array[0];
    for(int i = 1; i< array.Length; i++)
    {
        if(array[i] > max) max = array[i];
    }
    return max;
}

double findmin(double[] array)
{
    double min = array[0];
    for(int i = 1; i< array.Length; i++)
    {
        if(array[i] < min) min = array[i];
    }
    return min;
}
Random rand = new Random();

double[] array = new double[rand.Next(3, 8)];
fillarray(array, 1, 20);
printarray(array);

Console.WriteLine("\n" + (findmax(array)-findmin(array)));