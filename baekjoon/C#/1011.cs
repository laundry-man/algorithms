using System;
using System.Collections.Generic;
using static System.Console;

// 풀이를 본 문제입니다.
class Program {
    static int bf(int r, int s) {
        int ret = 0;
        while (r > 0) {
            if (r > s * 2) {
                ret += 2;
                r -= s * 2;
                s++;
            }
            else {
                int q = r / s;
                r -= q * s;
                ret += q;
                s--;
            }
        }
        return ret;
    }
    
    static void Main() {
        int n = int.Parse(ReadLine());
        var a = new List<int>();

        for (int i = 0; i < n; i++) {
            var c = ReadLine().Split(' ');
            int x = int.Parse(c[0]);
            int y = int.Parse(c[1]);

            a.Add(bf(y - x, 1));
        }

        for (int i = 0; i < a.Count; i++)
            WriteLine(a[i]);
    }
}