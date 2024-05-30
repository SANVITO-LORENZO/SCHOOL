#pragma once
#include <iostream>
#include <string>
using namespace std;
class CMotore
{
private:
	int numCavalli, consumoAlKm;
public:

	CMotore(int numCavalli, int consumoAlKm);

	void setNumCavalli(int numCavalli);
	void setConsumoAlKm(int consumoAlKm);

	int getNumCavalli();
	float getConsumoAlKm();

	string toString();

};

