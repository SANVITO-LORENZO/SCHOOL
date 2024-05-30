#include"CVettore.h"
#include<iostream>
using namespace std;

void main() {
	CVettore *v1= new CVettore(10);
	//PUSH
	for (int i = 0; i < 15 ; i++)
	{
		v1->push(i + 1);
	}
	cout << "PUSH: " << endl << v1->toString() << endl;
	//POP
	v1->pop();
	cout << "POP: " << endl << v1->toString() << endl;
	//SET
	v1->set(2, 33);
	v1->set(4, 11);
	v1->set(7, 6);
	v1->set(13, 3);
	cout << "SET: " << endl << v1->toString() << endl;
	//GET
	int tmp = v1->get(3);
	cout << "GET: " << endl << to_string(tmp) << endl;
	//INSERT
	//v1->insert(3, 66);
	//cout << "INSERT: " << endl << v1->toString() << endl;
	//ROTATE
	v1->rotate(1, 15);
	cout << "ROTATE: " << endl << v1->toString() << endl;
	//SORT
	v1->sort(1);
	cout << "SORT: " << endl << v1->toString() << endl;
}


