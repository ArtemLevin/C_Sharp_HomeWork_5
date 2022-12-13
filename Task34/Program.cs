// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] CreateArray(int number)
{
    int [] array = new int[number];
    int i = 0;
    while (i < number)
    {
        array[i] = new Random().Next(100,1000);
        i ++;
    }
    return array;
}

void PrintArray(int [] array)
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
int number = new Random().Next(1,11);
int [] array = new int[number];
array = CreateArray(number);
Console.WriteLine("The computer prints the array... ");
Console.WriteLine(" ");
PrintArray(array);

int index = 0; 
int counter = 0;
while(index < array.Length)
{
    if(array[index]%2 == 0)
    {
        counter++;
    }
    index++;
}

Console.WriteLine(" ");
Console.WriteLine("The number of even elements in the array is "+ counter);

