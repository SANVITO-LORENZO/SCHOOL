#pragma once
#include "CVeicolo.h"

class CAuto : public CVeicolo
{
private:
protected:
	int numPorte, numPasseggeri;
public:
	//COSTRUTTORE
	CAuto(string m, string t, string c, int a, int p, int numPorte, int numPasseggeri);
	//SET
	void setNumPorte(int numPorte);
	void setNumPasseggeri(int numPasseggeri);
	//GET
	int getNumPorte();
	int getNUmPasseggeri();
	//METODI
	virtual string toString();
};

