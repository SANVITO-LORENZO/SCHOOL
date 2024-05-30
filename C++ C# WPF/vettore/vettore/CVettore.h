#pragma once
#include <string>
#include <iostream>
using namespace std;
class CVettore
{
private:

	int* vettore;
	int numEl;
	int l;

public:

	CVettore(int l);
	~CVettore();
	CVettore(const CVettore& other) {
		this->l = other.l;
		this->numEl = other.numEl;
		this->vettore = new int[this->l];
		for (int i = 0; i < this->numEl; i++)
		{
			this->vettore[i] = other.vettore[i];
		}
	}

	void push(int num);
	int pop();

	void ridimensiona(int dimensione);

	int get(int i);

	void rotate(bool direzione, int numEl);

	string toString();

	CVettore find(int numero);
	CVettore sort(bool senso);
	void shift(bool verso, int index);
	void remove(int index);
	void insert(int index, int value);

	void eliminaDuplicati();

	int getMax();
	int getMin();

	int getLunghezza();
	void setLunghezza(int lunghezza);
};

