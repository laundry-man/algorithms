using System;
using static System.Console;

public class Program {
    static public void Main(string[] args) {
       var s = ReadLine().Split(' ');
       int a = Convert.ToInt16(s[0]);
       int b = Convert.ToInt16(s[1]);
       Write(a + b);
    }
}