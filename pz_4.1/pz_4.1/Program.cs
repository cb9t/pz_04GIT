int[] nums = new int[50];
for (int i = 2, n = 0; i <= 100; i += 2, n++)
    nums[n] = i;
foreach (int i in nums)
    Console.WriteLine($" Element: {i}");