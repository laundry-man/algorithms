using System;
using static System.Console;

public class Program {
    static void Main() {
        int n = int.Parse(ReadLine());

        var iarr = new int[41];
        var sarr = new string[n];

        iarr[2] = iarr[1] = 1;
        for (int i = 3; i < iarr.Length; i++)
            iarr[i] = iarr[i - 1] + iarr[i - 2];

        for (int i = 0; i < n; i++) {
            int num = int.Parse(ReadLine());
            string a, b;

            if (num == 0) {
                a = "1";
                b = iarr[num].ToString();
            }
            else {
                a = iarr[num - 1].ToString();
                b = iarr[num].ToString();
            }

            sarr[i] = string.Format("{0} {1}", a, b);
        }

        for (int i = 0; i < sarr.Length; i++)
            WriteLine("{0}", sarr[i]);
    }
}
