/**
 反復処理

 https://ufcpp.net/study/csharp/st_loop.html
*/

// while 文
{
    int i = 0;
    while (i < 5)
    {
        Console.WriteLine($"i: {i}");
        i++;
    }

    Console.WriteLine("");

    // break
    int j = 0;
    while (true)
    {
        Console.WriteLine($"j: {j}");
        j++;
        if (j >= 5)
        {
            break;
        }
    }

    Console.WriteLine("");

    // continue
    int k = 0;
    while (k < 5)
    {
        k++;
        if (k % 2 == 0)
        {
            continue;
        }
        Console.WriteLine($"k: {k}");
    }
}

Console.WriteLine("");

// do-while 文
{
    int i = 0;
    do
    {
        Console.WriteLine($"i: {i}");
        i++;
    } while (i < 5);
}

Console.WriteLine("");

// for 文
{
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"i: {i}");
    }
}

Console.WriteLine("");

// foreach文
{
    var nums = new int[] { 1, 2, 3, 4, 5 };
    foreach (var num in nums)
    {
        Console.WriteLine($"num: {num}");
    }

    Console.WriteLine("");

    // クエリ式/LINQ
    var nums2 = new int[] { 1, 2, 3, 4, 5 };
    var sum1 = (
        from x in nums2
        where x % 2 == 1
        select x * x
    ).Sum();
    Console.WriteLine($"sum1: {sum1}");

    var sum2 = nums2
        .Where(x => x % 2 == 1)
        .Sum(x => x * x);
    Console.WriteLine($"sum2: {sum2}");
}
