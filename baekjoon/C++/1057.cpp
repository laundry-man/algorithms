#include <iostream>
using namespace std;
int a, b, c, d, cnt;
int main(void) {
    cin >> c >> c >> d;
    a = c > d ? d : c;
    b = c > d ? c : d;
    while (1) {
        cnt++;
        if (a % 2 && a + 1 == b) break;
        a = a % 2 ? a / 2 + 1 : a / 2;
        b = b % 2 ? b / 2 + 1 : b / 2;
    }
    cout << cnt;
    return 0;
}