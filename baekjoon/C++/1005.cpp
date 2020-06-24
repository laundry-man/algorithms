#include <iostream>
#include <vector>
#include <queue>
#include <algorithm>
using namespace std;
int t, n, k, w, hr, tr;
int wght[1001],
    indgr[1001];
vector<int> otdgr[1001],
            wcnt[1001];
queue<int> q;
void qclear() {
    while (!q.empty()) q.pop();
}
int main(void) {
    ios::sync_with_stdio(0);
    cin.tie(0);
    cin >> t;
    while (t--) {
        cin >> n >> k;
        for (int i = 1; i <= n; i++)
            cin >> wght[i];
        for (int i = 0; i < k; i++) {
            cin >> hr >> tr;
            indgr[tr]++;
            otdgr[hr].push_back(tr);
        }
        cin >> w;
        for (int i = 1; i <= n; i++)
            if (!indgr[i])
                q.push(i);
        while (!q.empty()) {
            int h = q.front();
            if (h == w) {
                cout << wght[h] << '\n';
                qclear();
                for (int i = 1; i <= n; i++) {
                    wcnt[i].clear();
                    otdgr[i].clear();
                    indgr[i] = 0;
                }
                break;
            }
            for (int i = 0; i < otdgr[h].size(); i++) {
                int t = otdgr[h][i];
                wcnt[t].push_back(wght[h]);
                indgr[t]--;
                if (!indgr[t]) {
                    sort(wcnt[t].begin(), wcnt[t].end(), greater<int>());
                    wght[t] += wcnt[t][0];
                    q.push(t);
                }
            }
            q.pop();
        }
    }
    return 0;
}