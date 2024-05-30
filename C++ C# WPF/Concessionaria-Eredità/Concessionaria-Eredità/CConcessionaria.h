#pragma once
#include "CVeicolo.h"
#define MAXEL 5
class CConcessionaria
{
private:
protected:
	int numVeicoli;
	int lunghezza;
	CVeicolo* vett[MAXEL];
public:
	//COSTRUTTORE
	CConcessionaria();
	void addVeicolo(CVeicolo* v);
	//METODI
	string toString();
};

