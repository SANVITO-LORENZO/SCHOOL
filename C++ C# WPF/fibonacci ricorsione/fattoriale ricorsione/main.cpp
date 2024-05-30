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

}