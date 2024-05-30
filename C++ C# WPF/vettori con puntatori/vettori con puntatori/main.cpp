#include <iostream>
#define MAX 10
using namespace std;


int* restituisciEAumenta(int v[], int numEl) {
	int* vett_p = new int[numEl];
	for (int i = 0; i < numEl; i++)
	{
		vett_p[i] = v[i] + 1;
	}
	return vett_p;
}


void main() {

	int vett[MAX] = { 1,2,3,4,5,6,7,8,9,10 };

	cout << "VETTORE NORMALE:" <<endl;

	for (int i = 0; i < MAX; i++)
	{
		cout << vett[i] << "\t";
	}

	cout << endl << "VETTORE AUMENTATO:" <<endl;

	int* v = restituisciEAumenta(vett, MAX);
	for (int i = 0; i < MAX; i++)
	{
		cout << v[i] << "\t";
	}
}