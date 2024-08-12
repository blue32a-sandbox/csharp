/**
 定数

 https://ufcpp.net/study/csharp/sp_const.html
*/

// 変化しない値
{
    const int NUM = 10;
    // NUM = 20; // エラー
    Console.WriteLine(NUM); // 10
}

// const メンバー
class Foo
{
    // constメンバー
    private const int NUM = 20;
    public Foo()
    {
        // NUM = 30; // エラー
        Console.WriteLine(NUM); // 20
    }
}
new Foo();

// readonly
class Bar
{
    // readonlyメンバー
    private readonly int num = 30;
    public Bar()
    {
        // num = 40; // エラー
        Console.WriteLine(num); // 30
    }
}
new Bar();

// 定数にできるもの
{
    // enum
    const DayOfWeek D1 = DayOfWeek.Sun;

    // リテラル同士の計算
    const int I = 3 * 5;

    // 他の定数を参照
    const int J = 2 * I;

    // 文字列
    const string S = "Hello," + " World!";

    // その他の型では、nullのみ
    const object N = null;
}
enum DayOfWeek
{
    Sun, Mon, Tue, Wed, Thu, Fri, Sat
}
