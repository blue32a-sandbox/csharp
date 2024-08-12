/**
 配列

 https://ufcpp.net/study/csharp/st_array.html
*/

// 配列を使う
{
    // 配列の実体を作成する
    int[] a = new int[5];

    for (int i = 0; i < a.Length; i++)
    {
        a[i] = i;
    }

    int square_sum = 0;
    for (int i = 0; i < a.Length; i++)
    {
        square_sum += a[i] * a[i];
    }
    Console.WriteLine(square_sum); // 30
}

Console.WriteLine("");

{
    // 宣言時に初期化する
    int[] a = new int[] {1, 3, 5, 7, 9};
    foreach (var x in a)
    {
        Console.WriteLine(x);
    }

    // 暗黙的型付け配列
    var b = new int[] {1, 3, 5, 7, 9};
}

Console.WriteLine("");

// 多次元配列
{
    int[,] arr1 = new int[,]{
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9},
    };
    for (int i = 0; i < arr1.GetLength(0); i++) {
        for (int j = 0; j < arr1.GetLength(1); j++) {
            Console.Write(arr1[i, j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("");

    // 配列の配列
    int[][] arr2 = new int[][]{
        new int[]{1, 2, 3},
        new int[]{4, 5, 6},
        new int[]{7, 8, 9},
    };
    for (int i = 0; i < arr2.Length; i++) {
        for (int j = 0; j < arr2.Length; j++) {
            Console.Write(arr2[i][j] + " ");
        }
        Console.WriteLine();
    }
}
