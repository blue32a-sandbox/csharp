/**
 組込型

 https://ufcpp.net/study/csharp/st_embeddedtype.html
*/

// 整数型
byte    b; // 0 ～ 255
sbyte  sb; // -128 ～ 127
short   s; // -32,768 ～ 32,767
ushort us; // 0 ～ 65,535
int     i; // -2,147,483,648 ～ 2,147,483,647
uint   ui; // 0 ～ 4,294,967,295
long    l; // -9,223,372,036,854,775,808 ～ 9,223,372,036,854,775,807
ulong  ul; // 0 ～ 18,446,744,073,709,551,615


int   o = 351; // 整数リテラル
uint  p = 86U; // Uを付けると符号なし
long  q = 1879L; // Lを付けるとlong
ulong r = 2419UL; // UとLを付けるとulong

// 文字型
char c = 'a'; // 文字リテラル

short x = (short)'a';
Console.WriteLine(x); // 97

char y = (char)97;
Console.WriteLine(y); // a

char quote = '\''; // エスケープシーケンス
Console.WriteLine(quote); // '

// 浮動小数点型（実数型）
double f = 3.14; // 浮動小数点リテラル
float fl = 2.7183f; // fを付けると単精度
double db = 6.02e23; // 指数表記  6.02 x 10^23

// デシマル（10進小数）
decimal dm = 0.1m; // デシマルリテラル
Console.WriteLine(dm); // 0.1

// 論理値型
bool bl = 1 == 1;
Console.WriteLine(bl); // True
bool tr = true;
bool fls = false;

// 文字列型
string str = "C#入門"; // 文字列リテラル
string kao = "\uff9f\u0434\uff9f"; // Unicodeを直接入力
Console.WriteLine(kao); // ﾟдﾟ

string path = @"C:\windows\system"; // 逐語的リテラル（@-quoted string）
Console.WriteLine(path); // C:\windows\system

string multiLineString =
@"@-quoted string では、
文章を複数行に渡って書くことができます。
";
Console.Write(multiLineString);

// オブジェクト型
object oi = 123;
object oc = 'A';
object os = "Hello";
object ob = true;
object notInitializedVariable = null;

// 既定値
Console.WriteLine(default(int)); // 0
Console.WriteLine(default(bool)); // False
Console.WriteLine(default(string)); // null
