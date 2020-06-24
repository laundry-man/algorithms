#include <iostream>
#include <queue>
using namespace std;
int gph[50][50];
int yd[4] = { -1, 0, 1, 0 },
    xd[4] = { 0, 1, 0, -1 };
int t, m, n, k, x, y;

int bfs(int v, int h) {
    gph[v][h] = 0;
    queue<pair<int, int>> q;
    q.push(make_pair(v, h));
    while (!q.empty()) {
        auto p = q.front();
        q.pop();
        for (int i = 0; i < 4; i++) {
            int dy = p.first + yd[i],
                dx = p.second + xd[i];
            if (dy < 0 || dy > n - 1 || dx < 0 || dx > m - 1)
                continue;
            if (gph[dy][dx]) {
                gph[dy][dx] = 0;
                q.push(make_pair(dy, dx));
            }
        }
    }
    return 1;
}

int main(void) {
    ios::sync_with_stdio(0);
    cin.tie(0);
    cin >> t;
    while (t--) {
        int ans = 0;
        cin >> m >> n >> k;
        for (int i = 0; i < k; i++) {
            cin >> x >> y;
            gph[y][x] = 1;
        }
        for (int i = 0; i < n; i++)
            for (int j = 0; j < m; j++)
                if (gph[i][j]) 
                    ans += bfs(i, j);
        cout << ans << '\n';
    }
    return 0;
}