// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
//  максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] CreateArray(int number)
{
    Random rnd = new Random();
    double [] array = new double[number];
    int i = 0;
    while (i < number)
    {
        array[i] = new Random().Next(0, 100) + Math.Round(rnd.NextDouble(), 3);;
        i ++;
    }
    return array;
}

void PrintArray(double [] array)
{
    int i = 0;
    while (i < array.Length)
    {
        Console.Write(array[i] + " ");
        i++;
    } 
}

Console.WriteLine("The computer selects the size of the array... ");
Console.WriteLine("The computer selects the elements of the array... ");
int number = new Random().Next(5,11);
double [] array = new double[number];
array = CreateArray(number);
Console.WriteLine("The computer prints the array... ");
Console.WriteLine(" ");
PrintArray(array);


double DifferenceMaxMin(double [] array)
{
    int index = 0;
    double max = array[0];
    double min = array[0];
    double delta;
    while(index < array.Length)
    {
        if(array[index] > max)
        {
            max=array[index]; 
        }
        if(array[index] < min)
        {
            min=array[index]; 
        }
        index++;
    }

    return delta = max - min;
}

Console.WriteLine(" ");
Console.WriteLine("The difference between the largest value and the smallest value of the array is "+ DifferenceMaxMin(array));