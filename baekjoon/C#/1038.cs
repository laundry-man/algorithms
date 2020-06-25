using System.Collections.Generic;
using static System.Console;

class Program {
    static List<string>[,] arr = 
        new List<string>[10,10];
        
    static void Main() {
        int n = int.Parse(ReadLine());
        if (n > 1022) { Write(-1); return; }

        int cnt = -1;
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++)
                arr[i,j] = new List<string>();
            arr[0,i].Add(i.ToString());
            cnt++;
            if (cnt == n) { Write(i); return; }
        }

        for (int i = 1; i < 10; i++)
            for (int j = i; j < 10; j++)
                for (int k = 0; k < j; k++)
                    for (int l = 0; l < arr[i - 1, k].Count; l++) {
                        arr[i,j].Add(j.ToString() + arr[i - 1, k][l]);
                        cnt++;
                        if (cnt == n) { 
                            Write(j.ToString() + arr[i - 1, k][l]); 
                            return; 
                        }
                    }
    }
}