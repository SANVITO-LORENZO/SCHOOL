#include"calc.h"
#include<iostream>
using namespace std;

void main() {

    int tmp = 5;

    cout << "SOMMA: " << to_string(tmp) << " + " << to_string(tmp) << " = " << to_string(calc<int>::somma(tmp, tmp)) << endl;
    cout << "DIFFERENZA: " << to_string(tmp) << " - " << to_string(tmp) << " = " << to_string(calc<int>::differenza(tmp, tmp)) << endl;
    cout << "MOLTIPLICAZIONE: " << to_string(tmp) << " * " << to_string(tmp) << " = " << to_string(calc<int>::moltiplicazione(tmp, tmp)) << endl;
    cout << "DIVISIONE: " << to_string(tmp) << " / " << to_string(tmp) << " = " << to_string(calc<int>::divisione(tmp, tmp)) << endl;
}