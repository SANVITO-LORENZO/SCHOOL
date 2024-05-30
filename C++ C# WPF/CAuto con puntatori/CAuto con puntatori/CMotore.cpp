#include "CMotore.h"


CMotore::CMotore(int numCavalli, int consumoAlKm)
{
    setNumCavalli(numCavalli);
    setConsumoAlKm(consumoAlKm);
}

void CMotore::setNumCavalli(int numCavalli)
{
    this->numCavalli = numCavalli;
}

void CMotore::setConsumoAlKm(int consumoAlKm)
{
    this->consumoAlKm = consumoAlKm;
}

int CMotore::getNumCavalli()
{
    return numCavalli;
}

float CMotore::getConsumoAlKm()
{
    return consumoAlKm;
}

string CMotore::toString()
{
    string tmp = "";
    tmp += "MOTORE:\n";
    tmp += "numCavalli: " + to_string(numCavalli) + "\n";
    tmp += "consumoAlKm: " + to_string(consumoAlKm) + "\n";
    return tmp;
}
