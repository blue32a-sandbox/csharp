/**
 組込み型変換

 https://ufcpp.net/study/csharp/st_cast.html
*/

// 暗黙的な型変換
{
    short m = 365;
    long n = m;
    double x = n;

    // 符号付きから符号なしへの変換は暗黙的に行えない
    // int i = 42;
    // uint ui = i;

    // 値の範囲が狭い型への変換は暗黙的に行えない
    // int i = 1;
    // short s = i;
}

// 明示的な型変換
{
    int i = 42;
    short s = (short)i; // キャストによる明示的な型変換
}
