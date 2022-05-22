// Знакомство с языками программирования (семинары)
// Урок 8. Как не нужно писать код. Часть 2
/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/
/*
// задаем двумерный массив m x n

int[,] CreateArray(int m, int n)
{
    int[,] a = new int[m,n]; // двумерный массив для условия задачи
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            a[i, j] = new Random().Next(1, 20);
            //Console.Write(a[i, j] + "\t");
            Console.Write(a[i, j] + " ");
        }
        Console.WriteLine();
    }
// создали двумерный массив целых чисел размером m x n, со случайными элементами от 1 до 20
            //сортируем
    Console.WriteLine("Массив с упорядоченными по возрастанию элементами каждой строки: ");
            for (int i = 0; i < a.GetLength(0); i++)
                //сортировка пузырьком
                for (int j = 0; j < a.GetLength(1); j++)
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        if (a[i, j] >= a[i, k]) continue;
                        int temp = a[i, j];
                        a[i, j] = a[i, k];
                        a[i, k] = temp;
                    }
 
            for (int i = 0; i < a.GetLength(0); i++, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
 
    return a;
}
Console.Write("Количество строк в массиве 'm': ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов в массиве 'n': ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заданный массив: ");
Console.WriteLine();
CreateArray(m, n);

*/




// Знакомство с языками программирования (семинары)
// Урок 8. Как не нужно писать код. Часть 2
/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
// задаем двумерный массив m x n

int[,] CreateArray(int m, int n)
{
    int[,] array = new int[m,n]; // двумерный массив для условия задачи
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
// создали двумерный массив целых чисел размером m x n, со случайными элементами от 1 до 10

int sum = int.MaxValue;
int index = 0;
for (int i = 0; i < m; i++)
{
    int temp = 0;
    for (int j = 0; j < n; j++)
    {
        temp += array[i, j];
    }
    if (temp < sum)
    {
        sum = temp;
        index = i;
    }
}
Console.WriteLine();
Console.WriteLine("Строка: "+index+"; Наименьшая сумма: "+sum);
Console.WriteLine();

    return array;
}
Console.Write("Количество строк в массиве 'm': ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов в массиве 'n': ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заданный массив: ");
Console.WriteLine();
CreateArray(m, n);

*/

/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:

1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/
/*
Console.Write("Количество строк в массиве 'm': ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Количество столбцов в массиве 'n': ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заполненый спирально массив: ");
Console.WriteLine();

int[,] mas = new int[m, n]; 
int k = 1; 
int t = 0; 
int i, j = 0; 
int n1 = n; 
int m1 = m; 
 
while (k <= n1 * m1) 
{ 
for (i = t; i < n; i++) 
mas[j, i] = k++; 
j = n - 1; 
for (i = t + 1; i < m; i++) 
mas[i, j] = k++; 
j = m - 1; 
for (i = n - 2; i >= t; i--) 
mas[j, i] = k++; 
j = t; 
for (i = m - 2; i > t; i--) 
mas[i, j] = k++; 
n--; 
m--; 
t++; 
j = t; 
} 
for (i = 0; i < mas.GetLength(0); i++) 
{ 
for (j = 0; j < mas.GetLength(1); j++) 
Console.Write("{0,2} ", mas[i, j]); 
Console.WriteLine(); 
} 
 
*/
