using System;

namespace CsharpDay05Assignment
{

    class Part01
    {
        static void Main()
        {
            // =======================
            // part1
            // =======================
    
        //    #region problem 1
        //    try
        //    {
        //        int x = int.Parse(Console.ReadLine());
        //        int y = int.Parse(Console.ReadLine());
        //        Console.WriteLine(x / y);
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("Cannot divide by zero");
        //    }
        //    finally
        //    {
        //        Console.WriteLine("Operation complete");
        //    }
        //    #endregion
    
        //    #region problem 2
        //    int a, b;
        //    do { } while (!int.TryParse(Console.ReadLine(), out a) || a <= 0);
        //    do { } while (!int.TryParse(Console.ReadLine(), out b) || b <= 1);
        //    Console.WriteLine($"{a} {b}");
        //    #endregion
    
        //    #region problem 3
        //    int? n = null;
        //    int v = n ?? 10;
        //    Console.WriteLine(v);
        //    Console.WriteLine(n.HasValue ? n.Value.ToString() : "Null");
        //    #endregion
    
        //    #region problem 4
        //    int[] arr1 = new int[5];
        //    try
        //    {
        //        Console.WriteLine(arr1[10]);
        //    }
        //    catch (IndexOutOfRangeException)
        //    {
        //        Console.WriteLine("Index out of range");
        //    }
        //    #endregion
    
        //    #region problem 5
        //    int[,] m = new int[3, 3];
        //    for (int i = 0; i < 3; i++)
        //        for (int j = 0; j < 3; j++)
        //            m[i, j] = int.Parse(Console.ReadLine());
    
        //    for (int i = 0; i < 3; i++)
        //    {
        //        int rs = 0, cs = 0;
        //        for (int j = 0; j < 3; j++)
        //        {
        //            rs += m[i, j];
        //            cs += m[j, i];
        //        }
        //        Console.WriteLine($"{rs} {cs}");
        //    }
        //    #endregion
    
        //    #region problem 6
        //    int[][] jag = new int[3][];
        //    jag[0] = new int[2];
        //    jag[1] = new int[3];
        //    jag[2] = new int[1];
    
        //    for (int i = 0; i < jag.Length; i++)
        //        for (int j = 0; j < jag[i].Length; j++)
        //            jag[i][j] = int.Parse(Console.ReadLine());
    
        //    foreach (var r in jag)
        //    {
        //        foreach (var x in r)
        //            Console.Write(x + " ");
        //        Console.WriteLine();
        //    }
        //    #endregion
    
        //    #region problem 7
        //    string? name = null;
        //    if (Console.ReadLine() == "yes")
        //        name = "User";
        //    Console.WriteLine(name!);
        //    #endregion
    
        //    #region problem 8
        //    int num = 5;
        //    object o = num;
        //    try
        //    {
        //        int u = (int)o;
        //        Console.WriteLine(u);
        //    }
        //    catch (InvalidCastException)
        //    {
        //        Console.WriteLine("Invalid cast");
        //    }
        //    #endregion
    
        //    #region problem 9
        //    int s, p;
        //    SumAndMultiply(3, 4, out s, out p);
        //    Console.WriteLine($"{s} {p}");
        //    #endregion
    
        //    #region problem 10
        //    PrintText("Hello", times: 3);
        //    #endregion
    
        //    #region problem 11
        //    int[]? na = null;
        //    Console.WriteLine(na?.Length);
        //    #endregion
    
        //    #region problem 12
        //    string day = Console.ReadLine();
        //    int d = day switch
        //    {
        //        "Monday" => 1,
        //        "Tuesday" => 2,
        //        "Wednesday" => 3,
        //        "Thursday" => 4,
        //        "Friday" => 5,
        //        "Saturday" => 6,
        //        "Sunday" => 7,
        //        _ => 0
        //    };
        //    Console.WriteLine(d);
        //    #endregion
    
        //    #region problem 13
        //    Console.WriteLine(SumArray(1, 2, 3));
        //    Console.WriteLine(SumArray(new int[] { 4, 5, 6 }));
        //    #endregion
        //}
    
        //static void SumAndMultiply(int x, int y, out int sum, out int product)
        //{
        //    sum = x + y;
        //    product = x * y;
        //}
    
        //static void PrintText(string text, int times = 5)
        //{
        //    for (int i = 0; i < times; i++)
        //        Console.WriteLine(text);
        //}
    
        //static int SumArray(params int[] numbers)
        //{
        //    int sum = 0;
        //    foreach (int n in numbers)
        //        sum += n;
        //    return sum;
        }
    }
}