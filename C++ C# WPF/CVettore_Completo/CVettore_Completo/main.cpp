#include"CVettore.h"
#include<iostream>
#include<ctime>
using namespace std;
void main() {

	CVettore* v1 = new CVettore(10, 0);
	srand(time(NULL));
	//PUSH
	for (int i = 0; i < 12; i++)
	{
		v1->push(rand() % 10 + 1);
	}
	cout << "PUSH: " << endl << v1->toString() << endl;

	//POP
	int pop= v1->pop();
	cout << "POP: " << endl << to_string(pop) << endl;

	//GET MAX
	int max = v1->getMax();
	cout << endl << "MAX: " << endl << to_string(max) << endl;

	//GET MIN
	int min = v1->getMin();
	cout << "MIN: " << endl << to_string(min) << endl;

	//ROTATE
	cout << endl << "VETTORE: " << endl << v1->toString() << endl;
	v1->rotate(0);
	cout << "ROTATE DESTRA: " << endl << v1->toString() << endl;
	v1->rotate(1);
	cout << "ROTATE SINISTRA: " << endl << v1->toString() << endl;

	//SHIFT
	cout << endl << "VETTORE: " << endl << v1->toString() << endl;
	v1->shift(0);
	cout << "SHIFT DESTRA: " << endl << v1->toString() << endl;
	v1->shift(1);
	cout << "SHIFT SINISTRA: " << endl << v1->toString() << endl;

	//INSERT
	cout << endl << "VETTORE: " << endl << v1->toString() << endl;
	v1->insert(2,10);
	cout << "INSERT: " << endl << v1->toString() << endl;

	//FIND 
	cout << endl << "VETTORE: " << endl << v1->toString() << endl;
	CVettore v2 = v1->find(1);
	cout << "FIND: " << endl << v2.toString() << endl;

	//SORT
	cout << endl << "VETTORE: " << endl << v1->toString() << endl;
	CVettore v3 = v1->sort(1);
	cout << "SORT: " << endl << v3.toString() << endl;

	//SORT
	cout << endl << "VETTORE: " << endl << v1->toString() << endl;
	CVettore v4 = v1->eliminaDuplicati();
	cout << "ELIMINA DUPLICATI: " << endl << v4.toString() << endl;

}