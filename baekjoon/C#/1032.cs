using System;
using static System.Console;

class Program {
    static void Main() {
        int n = int.Parse(ReadLine());
        var l = new string[n];

        for (int i = 0; i < n; i++) 
            l[i] = ReadLine();

        for (int j = 0; j < l[0].Length; j++) {
            int c = 1, t = 0;
            for (int i = 0; i < n; i++) {
                if (i == 0) { t = l[i][j]; continue; }
                if (t != l[i][j]) { c = 0; break; }
            }
            
            if (c == 1) Write((char)t);
            else Write('?');
        }
    }
}