/**
 変数と式

 https://ufcpp.net/study/csharp/st_variable.html
*/

// 変数宣言
bool   b1;
int    n1;
double x1;
char   c1;
string s1;

// 型推論
var b2 = true;
var n2 = 42;
var x2 = 3.14;
var c2 = 'A';
var s2 = "Hello";

// varには右辺値が必要
// var y;
// y = 1;

// 変数の型を変更することはできない
// var z = 0;
// z = "";

// タプル
var (x, y) = (1, 2);
var (sum, dif) = (x + y, x - y);
Console.WriteLine("x + y = " + sum);
Console.WriteLine("x - y = " + dif);

// 逐語的識別子
var @int = 1;
var @string = "Hello";
var @if = "if";
var @for = "for";

// 式と演算子
int a = 3, b = 5, c, d;
c = (a + b) / 2;
d = a * b;
Console.WriteLine("c = " + c);
Console.WriteLine("d = " + d);

// 複文（ブロック）
{
    c = (a + b) / 2;
    d = a * b;
}
