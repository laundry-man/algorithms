using System;
using System.Collections.Generic;
using static System.Console;

class Program {
    static void Main() {
        ReadLine(); 
        var t = ReadLine().Split(' ');
        var l = new List<int>(); 
        foreach (var i in t) 
            l.Add(int.Parse(i)); 
        l.Sort();
        Write(l[0] * l[l.Count - 1]);
    }
}