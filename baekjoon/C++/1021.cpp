#include <iostream>
#include <vector>
#include <deque>
using namespace std;

int main(void) {
    ios::sync_with_stdio(0);
    cin.tie(0);
    deque<int> dq;
    vector<int> find; 
    int n, f, s = 0; cin >> n >> f;
    for (int i = 0; i < n; i++)
        dq.push_back(0);
    for (int i = 0, buf; i < f; i++) {
        cin >> buf; 
        find.push_back(buf - 1);
    }
    int p = 0;
    while (p != find.size()) {
        int l = find[p++];
        int size = dq.size(), d;
        int test = size % 2 == 0 ? size / 2 - 1 : size / 2;
        if (l > test) {
            d = size - l;
            for (int i = 0; i < d; i++) {
                dq.push_front(dq.back());
                dq.pop_back();
                for (int j = p; j < find.size(); j++)
                    if (find[j] + 1 > dq.size() - 1)
                        find[j] = 0;
                    else
                        find[j]++;
            }
            dq.pop_front();
            for (int j = p; j < find.size(); j++)
                find[j]--;
            s += d;
        }
        else {
            d = l;
            for (int i = 0; i < d; i++) {
                dq.push_back(dq.front());
                dq.pop_front();
                for (int j = p; j < find.size(); j++)
                    if (find[j] - 1 < 0)
                        find[j] = dq.size() - 1;
                    else
                        find[j]--;
            }
            dq.pop_front();
            for (int j = p; j < find.size(); j++)
                find[j]--;
            s += d;
        }
    }  
    cout << s;
    return 0;
}