#include "CMoto.h"

CMoto::CMoto(string m, string t, string c, int a, int p, int numRuote):CVeicolo(m,t,c,a,p)
{
    setNumRuote(numRuote);
}

void CMoto::setNumRuote(int numRuote)
{
    this->numRuote = numRuote;
}

int CMoto::getNumRuote()
{
    return numRuote;
}

string CMoto::toString()
{
    string tmp = CVeicolo::toString();
    tmp += "Numero ruote: " + to_string(numRuote) + "\n";
    return tmp;
}
