#include <iostream>
#include<time.h>
#include<string>

#define MAX 5
using namespace std;

string stampa(int a[], int numel) {
	string tmp ="";

	for (int i = 0; i < numel; i++)
	{
		tmp += to_string(a[i]) +"\t";
	}
	tmp += "\n";
	return tmp;
}
int* raddoppia(int a[],int numel) {
	int* v= new int[numel];

	for (int i = 0; i < numel; i++)
	{
		v[i] = a[i] * 2;
	}
	return v;
}

int* trovoPari(int a[], int numel) {
	int* v = new int[numel];

	for (int i = 0; i < numel; i++)
	{
		if ((a[i] % 2) == 0)
			v[i] = a[i];
		else
			v[i] = -1;	
	}
	return v;
}

int contaPari(int a[],int numel) {
	int tmp = 0;
	for (int i = 0; i < numel; i++)
	{
		if (a[i] % 2 == 0)
			tmp++;
	}
	return tmp;
}

int* trovoPari(int a[]) {

	int numel = contaPari(a,MAX);
	int* v = new int[numel];

	int tmp = 0;
	for (int i = 0; i < MAX; i++)
	{
		if ((a[i] % 2) == 0) {
			v[tmp] = a[i];
			tmp++;
		}
	}
	return v;
}
void main() {

	int a[MAX];
	srand(time(NULL));

	cout << "VETTORE A:" << endl;
	//inizializzo e stampo a
	for (int i = 0; i < MAX; i++)
	{
		a[i] = rand() % 10 + 1;
	}
	cout << stampa(a, MAX);

	int* b = raddoppia(a,MAX);

	cout << "VETTORE B:" << endl;
	//stampo b
	cout << stampa(b, MAX);

	int* c = trovoPari(a, MAX);

	cout << endl << "VETTORE C:" << endl;
	//stampo c
	cout << stampa(c, MAX);

	int* d = trovoPari(a);

	cout << endl << "VETTORE D:" << endl;
	//stampo c
	cout << stampa(d, contaPari(d,MAX));

}