#include "CSerbatoio.h"


CSerbatoio::CSerbatoio(int capacitaMax, int livelloAttuale)
{
    setCapacita(capacitaMax);
    setLivelloAttuale(livelloAttuale);
}

void CSerbatoio::setCapacita(int capacitaMax)
{
    this->capacitaMax = capacitaMax;
}

void CSerbatoio::setLivelloAttuale(int livelloAttuale)
{
    this->livelloAttuale = livelloAttuale;
}

float CSerbatoio::getCapacita()
{
    return capacitaMax;
}

int CSerbatoio::getLivelloAttuale()
{
    return livelloAttuale;
}

float CSerbatoio::riempiSerbatoio()
{
    float tmp = 0;
    tmp = (capacitaMax - livelloAttuale) * PREZZO;
    livelloAttuale = capacitaMax;
    return tmp;
}

void CSerbatoio::faiBenzina(int soldi)
{
    int tmp = soldi / PREZZO;
    livelloAttuale += tmp;
    if (livelloAttuale > capacitaMax)
        livelloAttuale = capacitaMax;
}
string CSerbatoio::toString()
{
    string tmp = "";
    tmp += "SERBATOIO:\n";
    tmp += "capacitaMax: " + to_string(capacitaMax) + "\n";
    tmp += "livelloAttualeCarburante: " + to_string(livelloAttuale) + "\n";
    return tmp;
}
