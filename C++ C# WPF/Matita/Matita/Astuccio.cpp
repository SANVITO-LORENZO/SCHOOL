#include "Astuccio.h"
#include <iostream>

Astuccio::Astuccio(bool flag)
{
	if (flag) {
		numeroMatite = maxMatite;
		srand(time(NULL));
		int n, lunghezza;
		for (int i = 0; i < numeroMatite; i++)
		{
			n = rand() % 2;
			lunghezza = rand() % 10 + 1;
			if (n == 0) {
				matite[i] = new Matita(lunghezza);
				cout << "matita\n";
			}
			else {
				matite[i] = new MatitaGommino(lunghezza);
				cout << "gommino\n";
			}
		}
	}
	else {
		numeroMatite = 0;
	}

}

void Astuccio::addMatita(Matita m)
{
	if (numeroMatite < maxMatite) {
		matite[numeroMatite++] = &m;
		//numeroMatite++;
	}
}

Matita Astuccio::getMatita(int i)
{
	if (i >= 0 && i < numeroMatite)
		return *matite[i];
	else
		return Matita();
}

string Astuccio::toString()
{
	string tmp;
	tmp += "Numero matite: " +to_string(numeroMatite) +"\n";
	for (int i = 0; i < numeroMatite; i++)
	{
		tmp += matite[i]->toString() + "\n";
	}
	return tmp;
}