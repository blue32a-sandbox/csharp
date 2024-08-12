/**
 組込み演算子

 https://ufcpp.net/study/csharp/st_operator.html
*/

// 算術演算子
Console.WriteLine(1 + 2); // 3
Console.WriteLine(1 - 2); // -1
Console.WriteLine(1 * 2); // 2
Console.WriteLine(9 / 2); // 4
Console.WriteLine(9 % 2); // 1

int a = 1;
Console.WriteLine(+a); // 1
Console.WriteLine(-a); // -1

// インクリメント・デクリメント
{
    // 前置インクリメント
    int a = 2;
    int b = ++a;
    Console.WriteLine(a); // 3
    Console.WriteLine(b); // 3
}
{
    // 後置インクリメント
    int a = 2;
    int b = a++;
    Console.WriteLine(a); // 3
    Console.WriteLine(b); // 2
}
{
    // 前置デクリメント
    int a = 2;
    int b = --a;
    Console.WriteLine(a); // 1
    Console.WriteLine(b); // 1
}
{
    // 後置デクリメント
    int a = 2;
    int b = a--;
    Console.WriteLine(a); // 1
    Console.WriteLine(b); // 2
}

// シフト
{
    var a = 0b_0011; // 3
    Console.WriteLine(a << 1); // 6
    Console.WriteLine(a >> 1); // 1
}

// 文字列連結
{
    var s = "Hello, " + "World!";
    Console.WriteLine(s); // Hello, World!
}

// 論理演算子
{
    Console.WriteLine(true & false); // True
    Console.WriteLine(201 & 92); // (1100 1001 AND 0101 1100) = 0100 1000 = 72

    Console.WriteLine(true | false); // True
    Console.WriteLine(201 | 92); // (1100 1001 OR 0101 1100) = 1101 1101 = 221

    Console.WriteLine(true ^ true); // False
    Console.WriteLine(201 ^ 92); // (1100 1001 XOR 0101 1100) = 1001 0101 = 149

    Console.WriteLine(!true); // False

    Console.WriteLine(~201); // ~(0000 0000 1100 1001) = 1111 1111 0011 0110 = -202
}

// 関係演算
{
    Console.WriteLine(1 == 1); // True
    Console.WriteLine(1 != 1); // False
    Console.WriteLine(1 < 2); // True
    Console.WriteLine(1 <= 2); // True
    Console.WriteLine(1 > 2); // False
    Console.WriteLine(1 >= 2); // False
}

// 代入演算
{
    int a = 1;
    Console.WriteLine(a);

    // 複合代入演算子
    int b = 1;
    b += 2;
    Console.WriteLine(b); // 3

    int c = 2;
    c -= 1;
    Console.WriteLine(c); // 1

    // null 合体代入
    string s = null;
    s ??= "Hello";
    Console.WriteLine(s); // Hello
}

// 条件演算子
{
    Console.WriteLine(true ? "Yes" : "No"); // Yes
}

// null 合体演算子
{
    string s = null;
    Console.WriteLine(s ?? "Hello"); // Hello
}

// sizeof 演算子
{
    Console.WriteLine(sizeof(int)); // 4
    Console.WriteLine(sizeof(byte)); // 1
}

// 短絡評価（左辺の結果によっては右辺が評価されない）
{
    var x = true | Echo("出力される");
    var y = true || Echo("出力されない");

    bool Echo(string str)
    {
        Console.WriteLine(str);
        return true;
    }
}
