// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] Generate_random_array_three_digit(int n)
{
    int[] RandomArray = new int [n];
    for (int i = 0; i < n; i++)
    {
        RandomArray[i] = new Random().Next(100, 1000);
    }
    return RandomArray;
}

void Show_array(int [] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write ("] -> ");
}

Console.WriteLine("Введите количество элементов в массиве"); 
int num_1 = Convert.ToInt32(Console.ReadLine()); 
int even_numbers = 0;


int [] array_random = Generate_random_array_three_digit (num_1);
Show_array(array_random);
    
    for (int j = 0; j < array_random.Length; j++)
    {
        if (array_random[j] % 2 == 0)
        {
            even_numbers = even_numbers + 1;
        }
        else
        {
            
        }
    }
Console.Write (even_numbers);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
