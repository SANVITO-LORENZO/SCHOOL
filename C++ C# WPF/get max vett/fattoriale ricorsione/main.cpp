#include"Calcoli.h"

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
}