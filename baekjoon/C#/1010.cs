using System;
using static System.Console;

public class Program {
    static void Main() {
        int.Parse(ReadLine());
        string buf;

        //입력값 int 변화
        int n = 0, m = 0;
        var c = new int[31, 31];

        //int 초기화
        for (int i = 0; i < 31; i++)
            for (int j = 0; j < 31; j++)
                c[i, j] = 0;

        //서쪽 다리가 1개만 주어질 경우 - 동쪽에 놓일 수 있는 다리의 수 (30)
        for (int i = 0; i < 31; i++)
            c[1, i] = i;

        //메모이제이션 시작.
        //2부터 접근 - 1인 경우는 모두 저장했기 때문.
        for (int i = 2; i < 31; i++) {
            //동쪽 다리는 서쪽 다리보다 적게 놓이는 경우가 없다.
            //같은 경우부터 시작해서 점차적으로 그 수를 늘린다.
            //*k 증가 = 3
            for (int k = i; k < 31; k++) {
                //첫번째 접근 - i = 2 / k = 2인 경우 - 경우의 수는?
                //c[1,1]의 int 와 같다.
                //c[2,2]에 그 수를 저장한다.

                //두번째 접근 - i = 2 / k = 3인 경우
                /* c[2,3]에 - c[1,1] 일때 경우의 수와 /
                   c[1,2]일 때 경우의 수 - 1과 2 더함 */
                for (int l = k - 1; l >= i - 1; l--) {
                    c[i, k] += c[i - 1, l];
                    //순환이 끝나면 *
                }
            }
        }
        
        while ((buf = ReadLine()) != null) {
            var rst = buf.Split(' ');
            if (rst.Length == 2) {
                n = int.Parse(rst[0]);
                m = int.Parse(rst[1]);
                WriteLine("{0}", c[n, m]);
            }
        }
    }
}