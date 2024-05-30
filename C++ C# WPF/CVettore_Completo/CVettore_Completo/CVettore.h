#pragma once
#include <string>
#include <iostream>
using namespace std;

class CVettore
{
private:

	int* vett;
	int numEl;
	int lunghezza;

public:

	//COSTRUTTORE-COPIA-DISTRUTTORE
	CVettore(int lunghezza, int numEl);
	~CVettore();
	CVettore(const CVettore& other);

	//PUSH-POP
	void push(int num);
	int pop();

	//METODI GET
	int get(int indice);
	int getMax();
	int getMin();
	int getLunghezza();
	int getNumEl();

	//METODI SET
	void setLunghezza(int lunghezza);
	void setNumEl(int numEl);

	//METODI
	void rotate(bool direzione);

	void shift(bool verso);
	void remove(int index);
	void insert(int index, int value);

	void ridimensiona(int dimensione);//nuova dimensione del vettore

	CVettore eliminaDuplicati();

	CVettore find(int numero);//ritorna un vettore di indici

	CVettore sort(bool senso);

	CVettore concatena(CVettore v2);
	CVettore intesezione(CVettore v2);
	CVettore unione(CVettore v2);
	CVettore differenza(CVettore v2);
	bool uguali(CVettore v2);

	int contaUguali(CVettore v2);

	string toString();
};

