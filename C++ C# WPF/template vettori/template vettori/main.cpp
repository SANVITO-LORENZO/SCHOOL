#include <iostream>

using namespace std;
#include"Vettore.h"

void main() {
    Vettore<int> v1(3);
    v1[0] = 1;
    v1[1] = 2;
    v1[2] = 3;

    Vettore<int> v2(3);
    v2[0] = 4;
    v2[1] = 5;
    v2[2] = 6;

    Vettore<int> v3 = v1 + v2;

    for (int i = 0; i < 6; i++) {
        cout << v3[i] << " ";
    }

    cout << endl;
}
