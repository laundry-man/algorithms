using System;
using System.Collections.Generic;
using static System.Console;

public class Program {
    static void Main() {
        int n = int.Parse(ReadLine());

        var a = ReadLine().Split(' ');
        var b = ReadLine().Split(' ');
        
        var alist = new List<int>();
        var blist = new List<int>();
        
        for (int i = 0; i < n; i++) {
            alist.Add(int.Parse(a[i]));
            blist.Add(int.Parse(b[i]));
        }

        alist.Sort();
        blist.Sort((x,y) => y.CompareTo(x));

        int sum = 0;
        for (int i = 0; i < n; i++)
            sum += alist[i] * blist[i];

        Write(sum);
    }
}