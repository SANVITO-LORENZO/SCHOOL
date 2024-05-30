#include "Matita.h"

Matita::Matita()
{
}

Matita::Matita(int l):lunghezza(l)
{
	//lunghezza = l;
}

int Matita::getLunghezza()
{
	return lunghezza;
}

void Matita::tempera()
{
	if (lunghezza > 1) //una matita non può essere di lunghezza 0
		lunghezza--;
}

void Matita::tempera(int volte)
{
	if (volte > 0 && volte < lunghezza)
		lunghezza -= volte;
}

string Matita::toString()
{
	string s;
	s += "Lunghezza: " + to_string(getLunghezza()) + "\n";
	return s;
}