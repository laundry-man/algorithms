using System;
using static System.Console;

class Program {
    static char[,] str = new char[55, 55];
    static int y, x, i, j, a, b, and = int.MaxValue;
    
    static void Main() {
        var m = ReadLine().Split(' ');
        y = int.Parse(m[0]); 
        x = int.Parse(m[1]);
        
        for (i = 0; i < y; i++) {
            var n = ReadLine();
            for (j = 0; j < x; j++)
                str[i, j] = n[j]; 
        }
        
        for (i = 0; i < y - 7; i++) {
            for (j = 0; j < x - 7; j++) {
                int cnt = 0;
                for (a = i; a < i + 8; a++) {
                    for (b = j; b < j + 8; b++) {
                        if (((a & 1) ^ (b & 1)) == 1) { 
                            if (str[a,b] == 'W') 
                                cnt += 1; 
                        }
                        else { 
                            if (str[a,b] == 'B') 
                                cnt += 1; 
                        }
                    }
                }
                and = Math.Min(and, Math.Min(cnt, 64 - cnt));
            }
        }
        Write(and);
    }
}