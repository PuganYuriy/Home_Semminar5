int[] Generate_random_array_three_digit(int n) // создание функции для создания массива заполнеными трёхзначными цыфрами
{
    int[] RandomArray = new int [n];
    for (int i = 0; i < n; i++)
    {
        RandomArray[i] = new Random().Next(100, 1000); //заполнение массива случайными трехзначными числами от  100 до  1000
    }
    return RandomArray;
}

int[] Generate_random_array(int x, int min, int max) // создание функции для создания массива из случайно генерируемых цифр
{
    int[] RandomArray = new int [x];
    for (int i = 0; i < x; i++)
    {
        RandomArray[i] = new Random().Next(min, max + 1); //заполнение массива введеными цифрами от  min до  max 
    }
    return RandomArray;
}


void Show_array(int [] array) // создание метода  "Show_array" для вывода массива на консоль
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write ("] -> ");
}

void Sum_odd_array(int [] array) // создание метода  "Sum_odd_array" для суммирование нечетных индексов массива
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    Console.Write(sum);
}

void dif_array(int [] array) // создание метода  "dif_array" для вывода разницы между максимальным и минимальным значением массива
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        
        if (max < array[i])
        {
            max = array[i];
        }
        else if (min > array[i])
        {
            min = array[i];
        }        
        else {}
    }
    Console.Write(max - min);
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Console.WriteLine("Введите количество элементов в массиве"); 
// int num_1 = Convert.ToInt32(Console.ReadLine()); 
// int even_numbers = 0;


// int [] array_random = Generate_random_array_three_digit (num_1);
// Show_array(array_random);
    
//     for (int j = 0; j < array_random.Length; j++)
//     {
//         if (array_random[j] % 2 == 0)
//         {
//             even_numbers = even_numbers + 1;
//         }
//         else { }
//     }
// Console.Write (even_numbers);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// Console.WriteLine("Введите количество элементов в массиве"); 
// int a = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("ведите первое число случайно генирируемых числел"); 
// int beg_array = Convert.ToInt32(Console.ReadLine()); 

// Console.WriteLine("Введите последнее число случайно генирируемых числел"); 
// int end_array = Convert.ToInt32(Console.ReadLine()); 

// int [] array_1 = Generate_random_array (a, beg_array, end_array);
// Show_array(array_1);
// Sum_odd_array(array_1);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов в массиве"); 
int number_1 = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("ведите первое число случайно генирируемых числел"); 
int min_array = Convert.ToInt32(Console.ReadLine()); 

Console.WriteLine("Введите последнее число случайно генирируемых числел"); 
int max_array = Convert.ToInt32(Console.ReadLine()); 

int [] array_2 = Generate_random_array (number_1, min_array, max_array);
Show_array(array_2);
dif_array(array_2);