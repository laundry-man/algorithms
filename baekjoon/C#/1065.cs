using System;
using System.Collections.Generic;
using static System.Console;

public class Program {
    public static bool Judge(int l) {
        int[] k = new int[3];
        for (int i = l, j = 2; i > 0; i /= 10, j--)
            k[j] = i % 10;
        return k[1] - k[0] == k[2] - k[1];
    }

    static void Main() {
        int n = int.Parse(ReadLine());
        int m = 0;

        if (n == 1000)
            n -= 1;

        if (n < 100) {
            m = n;
        }
        else {
            m = 99;
            for (int i = 100; i <= n; i++)
                if (Judge(i))
                    m++;
        }
        
        WriteLine("{0}", m);
    }
}