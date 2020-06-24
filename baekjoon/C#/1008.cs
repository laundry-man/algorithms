using System;
using static System.Console;

public class Program {
    static void Main() {
        var s = ReadLine().Split(' ');
        var a = Convert.ToDouble(s[0]);
        var b = Convert.ToDouble(s[1]);
        Write(a / b);
    }
}