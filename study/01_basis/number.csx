/**
 数値

 https://ufcpp.net/study/csharp/start/stnumber/
*/

// 10進数以外の数値
var bin = 0xFF; // 16進数
Concole.WriteLine(bin); // 255

var hex = 0b10010101; // 2進数
Console.WriteLine(hex); // 149

// 数字区切り文字
var million = 1_000_000; // 1,000,000
var bin2 = 0b1010_1011_1100_1101;
var hex2 = 0xab_cd;
var f1 = 1.123_456_789;

// 先頭区切り文字（Ver.7.2～）
var hex2 = 0x_0001_F408;
var bin2 = 0b_1111_0000;
