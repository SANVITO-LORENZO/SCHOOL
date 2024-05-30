#include "MatitaGommino.h"

MatitaGommino::MatitaGommino(int lunghezza):Matita(lunghezza) {
	cancellature = 10;
}

void MatitaGommino::cancella()
{
	if (cancellature > 0)
		cancellature--;
}

int MatitaGommino::getCancellature()
{
	return cancellature;
}

string MatitaGommino::toString()
{
	string s = Matita::toString();
	s += "Cancellature: " + to_string(cancellature) + "\n";
	return s;
}