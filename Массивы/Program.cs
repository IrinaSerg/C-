﻿//int[] numbers = { 1, 2, 3, 4, 5 };
//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}


//int[] numbers = { -4, -3, -2, -1,0, 1, 2, 3, 4 };
             
//int n = numbers.Length; // длина массива
//int k = n / 2;          // середина массива
//int temp;               // вспомогательный элемент для обмена значениями
//for(int i=0; i < k; i++)
//{
//    temp = numbers[i];
//    numbers[i] = numbers[n - i - 1];
//    numbers[n - i - 1] = temp;
//}
//foreach(int i in numbers)
//{
//   Console.Write($"{i} \t");
//}

int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
 
// сортировка
int temp;
for (int i = 0; i < nums.Length - 1; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] > nums[j])
        {
            temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
 
// вывод
Console.WriteLine("Вывод отсортированного массива");
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}