#include"Calcoli.h"
#include <string>
#include <iostream>
using namespace std;
void main() {
	Calcoli fat;
	cout << "senza ricorsione: " << fat.getfattoriale(5) << endl;
	cout << "con ricorsione: " << fat.getFatRicorsione(5) << endl;

	int n = 20;

	for (int i = 0; i < n; i++) {
		cout << fat.fibonacci(i) << " ";
	}

	int v[] = { 20,2,11,30,5 };
	cout <<endl<< "massimo del vettore: " << fat.getMax(v, 5);

	int n1 = 1;
	int n2 = 4;
	cout << endl << "intervallo tra " + to_string(n1) + " e " + to_string(n2) + " : " << fat.getIntervallo(n1, n2);
}