#include "CConcessionaria.h"

CConcessionaria::CConcessionaria()
{
}

void CConcessionaria::addVeicolo(CVeicolo* v)
{
    if (lunghezza < MAXEL) {
        vett[lunghezza] = v;
        lunghezza++;
    }
}

string CConcessionaria::toString()
{
    string tmp = "";
    for (int i = 0; i < MAXEL; i++)
    {
        tmp += "VEICOLO " + to_string(i) + " :\n";
        tmp += vett[i]->toString();
    }
    return tmp;
}
