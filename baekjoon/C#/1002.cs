using System;
using System.Text;
using static System.Math;
using static System.Console;

class Program {
    static void Main() {
        var s = new StringBuilder();
        int t = int.Parse(ReadLine());
        while (t-- > 0) {
            var a = Array.ConvertAll(ReadLine().Split(), double.Parse);
            double b = Sqrt(Pow(a[0] - a[3], 2) + Pow(a[1] - a[4], 2)),
                   c = a[2],
                   d = a[5];
            if (a[0] == a[3] && a[1] == a[4] && a[2] == a[5])
                s.AppendLine("-1");
            else if (c + d > b && Abs(c - d) < b)
                s.AppendLine("2");
            else if (Abs(c - d) == b || c + d == b)
                s.AppendLine("1");
            else
                s.AppendLine("0");
        }
        Write(s);
    }
}