/**
 関数

 https://ufcpp.net/study/csharp/st_function.html
*/

// 関数定義
int Sum(int x, int y)
{
    return x + y;
}

// 関数呼び出し
int z = Sum(1, 2);
Console.WriteLine(z); // 3

// 複数個のreturn
int Max(int x, int y)
{
    if (x > y) return x;
    else return y;
}
Console.WriteLine(Max(1, 2)); // 2

// 関数のオーバーロード
void WriteTypeAndValue(string s)
{
    Console.WriteLine($"文字列 : {s}");
}
void WriteTypeAndValue(int n)
{
    Console.WriteLine($"整数   : {n}");
}
void WriteTypeAndValue(double x)
{
    Console.WriteLine($"実数   : {x}");
}

WriteTypeAndValue("Hello");
WriteTypeAndValue(123);
WriteTypeAndValue(3.14);

// expression-bodied な関数
int Square(int x) => x * x;
Console.WriteLine(Square(3)); // 9

// ローカル関数
int Sum2(int x, int y)
{
    return Add(x, y);

    int Add(int a, int b)
    {
        return a + b;
    }
}
Console.WriteLine(Sum2(1, 2)); // 3

// 匿名関数
Func<int, int> square = x => x * x;
Console.WriteLine(square(3)); // 9
