﻿Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static int getAverage(int[] nums)
{
    var sum = 0;
    foreach (var num in nums)
    {
        sum += num;
    }

    return sum / nums.Length;
}
int[] nums = {1,2,3,4,5};
var average = getAverage(nums);
Console.WriteLine(average);