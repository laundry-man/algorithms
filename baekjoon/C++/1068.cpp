#include <iostream>
#include <vector>
#include <queue>
using namespace std;
vector<int> v[50];
int a[50];

int main(void) {
    ios::sync_with_stdio(0);
    cin.tie(0);

    int n, t, f, 
        rt = 1, rv,
        cnt = 0; 
    cin >> n;

    for (int i = 0; i < n; i++) {
        cin >> t;
        a[i] = t;
        if (t < 0) rv = i;
        else v[t].push_back(i);
    }

    cin >> f;
    if (a[f] < 0) rt--;

    for (int i = 0; rt && i < v[a[f]].size(); i++)
        if (v[a[f]][i] == f) {
            v[a[f]].erase(v[a[f]].begin() + i);
            break;
        }

    queue<int> q;
    q.push(rv);

    while (rt && !q.empty()) {
        int p = q.front();
        if (!v[p].size())
            cnt++;
        else {
           for (int i = 0; i < v[p].size(); i++)
                q.push(v[p][i]);
        }
        q.pop();
    }

    cout << cnt;
    
    return 0;
}