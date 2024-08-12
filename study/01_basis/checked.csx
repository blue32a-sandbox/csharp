/**
 オーバーフローのチェック

 https://ufcpp.net/study/csharp/sp_checked.html
*/

// オーバーフロー
{
    sbyte a = 64; // 0100 0000
    sbyte b = 65; // 0100 0001
    sbyte c = (sbyte)(a + b); // 1000 0001 （sbyte では -127 を表す）
    Console.WriteLine("{0} + {1} = {2}", a, b, c); // 64 + 65 = -127
}

// checked キーワード
{
    try
    {
      checked
      {
        sbyte a = 64;
        sbyte b = 65;
        sbyte c = (sbyte)(a + b);
        Console.WriteLine("例外が発生するのでここは実行されない");
      }
    }
    catch(OverflowException ex)
    {
      Console.WriteLine(ex.Message);
    }
}

// unchecked キーワード
{
    try
    {
      unchecked
      {
        sbyte a = 64;
        sbyte b = 65;
        sbyte c = (sbyte)(a + b);
        Console.WriteLine("オーバーフローは無視され、例外は発生しない");
      }
    }
    catch(OverflowException ex)
    {
      Console.WriteLine(ex.Message);
    }
}

// 浮動小数点数型の場合のオーバーフロー
{
    float x = 1e30f;
    float y = 1e-30f;

    try {
        checked {
            // 値は無限大(infinity)になる
            Console.WriteLine("{0}, {1}", x*x, y*y); // +∞, 0
        }
    }
    catch(OverflowException ex)
    {
      Console.WriteLine("浮動小数点数の場合、例外は発生しない");
    }
}
