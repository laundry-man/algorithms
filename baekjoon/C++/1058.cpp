#include <iostream>
#include <string>
#include <vector>
#include <queue>
using namespace std;
int n, ans, vst[50];
vector<int> gph[50];

void bfs(int st) {
    int cnt = 0;
    queue<int> q; q.push(st);
    vst[st] = 1;
    while (!q.empty()) {
        int h = q.front(); q.pop();
        for (int i = 0; i < gph[h].size(); i++) {
            int t = gph[h][i];
            if (!vst[t]) {
                vst[t] = vst[h] + 1;
                if (vst[t] < 4) cnt++;
                q.push(t);
            }
        }
    }
    if (ans < cnt) ans = cnt;
    for (int i = 0; i < n; i++)
        vst[i] = 0;
}

int main(void) {
    ios::sync_with_stdio(0);
    cin.tie(0); cin >> n;
    cin.ignore(1000, '\n');
    for (int i = 0; i < n; i++) {
        string t; getline(cin, t);
        for (int j = 0; j < n; j++)
            if (t[j] == 'Y')
                gph[i].push_back(j);
    }
    for (int i = 0; i < n; i++)
        bfs(i);
    cout << ans;
    return 0;
}