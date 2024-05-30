#pragma once
#include "CVeicolo.h"
class CMoto : public CVeicolo
{
private:
protected:
	int numRuote;
public:
	//COSTRUTTORE
	CMoto(string m, string t, string c, int a, int p, int numRuote);
	//SET
	void setNumRuote(int numRuote);
	//GET
	int getNumRuote();
	//METODI
	virtual string toString();
};

