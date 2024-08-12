/**
 特殊な文字列リテラル

 https://ufcpp.net/study/csharp/st_string.html
*/

var x = 1;
var y = 2;
var formatted = string.Format("({0}, {1})", x, y); // 従来の方法
Console.WriteLine(formatted); // (1, 2)

var formatted2 = $"({x}, {y})"; // 補間文字列（string.Formatの面倒事を解決する）
Console.WriteLine(formatted2); // (1, 2)

// エスケープ $""
var p = new { X = 10, Y = 20 };
Console.WriteLine($"\"{{{p.X}, {p.Y}}}\""); // "{10, 20}"


// nameof 演算子
var myLocal = 10;
Console.WriteLine(nameof(myLocal) + " = " + myLocal); // myLocal = 10
