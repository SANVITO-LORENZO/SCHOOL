#pragma once
#include <iostream>
#include <string>
#define PREZZO 1.99;
using namespace std;
class CSerbatoio
{
private:
	int capacitaMax, livelloAttuale;
public:

	CSerbatoio(int capacitaMax, int livelloAttuale);

	void setCapacita(int capacitaMax);
	void setLivelloAttuale(int livelloAttuale);

	float getCapacita();
	int getLivelloAttuale();

	float riempiSerbatoio();
	void faiBenzina(int soldi);
	string toString();

};

