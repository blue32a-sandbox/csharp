/**
 条件分岐

 https://ufcpp.net/study/csharp/st_branch.html
*/

// if 文
{
    int x = 10;

    if(x == 0)
    {
        Console.WriteLine("x は 0 です");
    }
    else
    {
        Console.WriteLine("x は 0 ではありません");
    }

    // 条件演算子
    Console.WriteLine(x == 0 ? "x は 0 です" : "x は 0 ではありません");
}

// switch 文
{
    int x = 1;

    switch (x)
    {
        case 0:
            Console.WriteLine("x は 0 です");
            break;
        case 1:
            Console.WriteLine("x は 1 です");
            break;
        default:
            Console.WriteLine("x は 0, 1以外です");
            break;
    }

    // フォールスルーの禁止
    // switch (x)
    // {
    //     case 0:
    //         Console.WriteLine("フォールスルーは禁止されている");
    //     case 1:
    //         break;
    //     default:
    //         break;
    // }

    switch (x)
    {
        case 0:
        case 1:
            Console.WriteLine("連続したcaseラベルではフォールスルーが可能");
            break;
        default:
            break;
    }
}

// goto 文
{
    int i = 0;
    START:
    Console.WriteLine("gotoの例");
    i++;
    if (i < 3)
    {
        goto START;
    }

    int x = 1;
    switch (x)
    {
        case 1:
            Console.WriteLine("xは1です");
            goto case 2;
            break;
        case 2:
            Console.WriteLine("xは2です");
            break;
        default:
            break;
    }
}
