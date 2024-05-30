#pragma once
#include "Matita.h"
class MatitaGommino:public Matita
{
private:
	int cancellature;
public:
	MatitaGommino(int lunghezza);
	void cancella();
	int getCancellature();
	string toString();
};