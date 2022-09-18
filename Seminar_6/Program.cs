// Задача 1: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]



// int InputValue(string text)
// {
//     System.Console.Write($"{text} => ");
//     var value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// double[] GenArray(int n, int mingen, int maxgen)

// {
//     double[] arr = new double[n];
//     var random = new Random();
//     for (int i = 0; i < n; i++)
//     {
//         arr[i] = Math.Round(random.NextDouble() * (maxgen - mingen) + mingen, 2);
//     }
//     return arr;
// }

// double[] ArrayReverse(double[] array)
// {
//     var length = array.Length;
//     double temp;
//     for (int i = 0; i < length / 2; i++)
//     {
//         temp = array[i];
//         array[i] = array[length - 1 - i];
//         array[length - 1 - i] = temp;
//     }
//     return array;
// }

// void PrintArray(double[] array)
// {
//     var length = array.Length;

//     if (length == 1)
//     {
//         System.Console.WriteLine($"[ {array[0]} ]");
//     }
//     else
//     {
//         System.Console.Write("[ ");
//         for (int i = 0; i < length - 1; i++)
//         {
//             System.Console.Write($"{array[i]}, ");
//         }
//         System.Console.Write($"{array[length - 1]} ]");
//     }
// }

// int n = InputValue("Введите количество чисел массива");
// int mingen = InputValue("Задайте нижнюю границу массива");
// int maxgen = InputValue("Задайте верхнюю границу массива");

// var array = GenArray(n, mingen, maxgen);
// PrintArray(array);

// System.Console.WriteLine();

// var arrays = ArrayReverse(array);
// PrintArray(arrays);

// bool IfTriangle(int a, int b, int c)
// {
//     if (a < b + c && b < a + c && c < b + a) return true;
//     else return false;
// }



// void PrintResult(bool result, string TrueText, string FalseText)
// {
//     System.Console.WriteLine();
//     if (result == true)
//     {
//         System.Console.WriteLine($"{TrueText}");
//     }
//     else
//     {
//         System.Console.WriteLine($"{FalseText}");
//     }
// }

// int a = InputValue("Сторона А");
// int b = InputValue("Сторона B");
// int c = InputValue("Сторона C");
// PrintResult(IfTriangle(a, b, c), "Треугольник", "Не треугольник");

// int digit = InputValue("Для превода в двоичную систему исчисления введите число");

// int[] ToBinarNumb(int value)
// {
//     int[] result = new int[10];
//     int count = result.Length - 1;
//     while (value > 0)
//     {
//         result[count] = value % 2;
//         value = value / 2;
//         count--;
//     }
//     return result;
// }
// var array = ToBinarNumb(digit);

// void PrintArray(int[] arr)
// {
//     var length = arr.Length;
//     for (int i = 0; i < length; i++)
//     {
//         System.Console.Write(arr[i]);
//     }

// }


// PrintArray(array);


// int Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci (n - 2);


// }
// for (int i = 1; i < 10; i++)
// {
// if(i == 1 || i == 2)
//     System.Console.WriteLine(i);
//     else
//     { result[i] = 

//     }

// }


// int InputValue(string text)
// {
//     System.Console.WriteLine(text);
//     var value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// void  Fibonacci(int n)

// {
//  double[] array = new double[n];
//  var length =  array.Length;

//  {   
//  }
//    for (int i = 0; i < length; i++)
//    if(i == 0 || i == 1) System.Console.WriteLine($"n = {i + 1} => {array[i] = 1}");
//    else
//    {
//      array[i] = array[i-1] + array[i-2];
//      System.Console.WriteLine($"n = {i + 1 } => {array[i]}");
//    }
// }

// int value = InputValue("Введите число для построения последовательности Фибоначчи");
// Fibonacci(value);

// int InputValue(string text)
// {
//     System.Console.WriteLine($"{text}");
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }

// int[] GenArray(int n)
// {
//     int[] arr = new int[n];
//     var length = arr.Length;
//     var random = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         arr[i] = random.Next(0, 100);
//     }
//     return arr;
// }

// void PrintArray(int[] array)
// {
//     System.Console.WriteLine();
//     var length = array.Length;
//     System.Console.Write("[ ");
//     for (int i = 0; i < length - 1; i++)
//     {
//         System.Console.Write($"{array[i]}, ");
//     }
//     System.Console.Write($"{array[length - 1]} ]");
// }

// int[] CloneArray(int[] array)
// {
//     int[] clonearray = new int[array.Length];
//     for (int i = 0; i < clonearray.Length; i++)
//     {
//         clonearray[i] = array[i];
//     }
//     return clonearray;
// }
// var value = InputValue("Введите количество чисел в массиве");
// var arrayorgin = GenArray(value);
// PrintArray(arrayorgin);
// var clonearray = CloneArray(arrayorgin);
// PrintArray(clonearray);