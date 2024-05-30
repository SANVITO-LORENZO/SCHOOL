#pragma once
#include "MatitaGommino.h"
#include <time.h>

#define maxMatite 5
class Astuccio
{
private:
	Matita* matite[maxMatite];
	int numeroMatite;

public:
	Astuccio(bool flag);
	void addMatita(Matita m);
	Matita getMatita(int i);
	string toString();
};

