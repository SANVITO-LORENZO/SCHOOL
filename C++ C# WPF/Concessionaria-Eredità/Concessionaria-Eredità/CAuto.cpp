#include "CAuto.h"

CAuto::CAuto(string m, string t, string c, int a, int p, int numPorte, int numPasseggeri) :CVeicolo(m, t, c, a, p)
{
    setNumPasseggeri(numPasseggeri);
    setNumPorte(numPorte);
}

void CAuto::setNumPorte(int numPorte)
{
    this->numPorte = numPorte;
}

void CAuto::setNumPasseggeri(int numPasseggeri)
{
    this->numPasseggeri = numPasseggeri;
}

int CAuto::getNumPorte()
{
    return numPorte;
}

int CAuto::getNUmPasseggeri()
{
    return numPasseggeri;
}

string CAuto::toString()
{
    string tmp = CVeicolo::toString();
    tmp += "Numero porte" + to_string(numPorte) + "\n";
    tmp += "Numero passeggeri" + to_string(numPasseggeri) + "\n";
    return tmp;
}
