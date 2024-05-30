#pragma once
#include "CStudente.h"
class CRegistroElettronico
{
private:
	CStudente* vett;
	int numel;
	int maxel;
public:
	CRegistroElettronico(int maxel);

	void addStudente(CStudente* s);
	void ridimensiona(int nuovalunghezza);
	string mediVoti();
	string votoMax();
	string votoMin();
	void ordinaMedia();
	void ordinaCognome();

	string toString();
};

