#include "CAuto.h"


CAuto::CAuto(int kmPercorsi, int numPosti, CMotore* m, CSerbatoio* s, string targa)
{
    setMotore(m);
    setSerbatoio(s);
    setTarga(targa);
    setnumPosti(numPosti);
    setkmPercorsi(kmPercorsi);
}

CAuto::~CAuto()
{
    delete(m);
    delete(s);
    s = NULL;
    m = NULL;
}

void CAuto::setMotore(CMotore* m)
{
    this->m = m;
}

void CAuto::setSerbatoio(CSerbatoio* s)
{
    this->s = s;
}

void CAuto::setTarga(string targa)
{
    this->targa = targa;
}

void CAuto::setnumPosti(int numPosti)
{
    this->numPosti = numPosti;
}

void CAuto::setkmPercorsi(int kmPercorsi)
{
    this->kmPercorsi = kmPercorsi;
}

string CAuto::getTarga()
{
    return targa;
}

int CAuto::getnumPosti()
{
    return numPosti;
}

int CAuto::getkmPercorsi()
{
    return kmPercorsi;
}

float CAuto::getAutonomia()
{
    float consumo = m->getConsumoAlKm();
    float capacita = s->getCapacita();
    return capacita/ consumo;
}

void CAuto::percorriKm(int Km)
{
    int benzina = s->getLivelloAttuale();
    int consumo = m->getConsumoAlKm();
    int tmp = benzina - (Km * consumo);
    if (tmp>0)
    s->setLivelloAttuale(tmp);
    else
    s->setLivelloAttuale(0);
    kmPercorsi += Km;
}

bool CAuto::confontoAutonomia(CAuto a, CAuto b)
{
    if (a.getAutonomia() > b.getAutonomia())
        return true;
    else
        return false;
}

bool CAuto::confontoEconomia(CAuto a, CAuto b)
{
    if (a.getAutonomia() > b.getAutonomia())
        return true;
    else
        return false;
}

string CAuto::toString()
{
    string tmp = "";
    tmp += "AUTO:\n";
    tmp += "targa: " + targa + "\n";
    tmp += "numPosti: " + to_string(numPosti) + "\n";
    tmp += "kmPercorsi: " + to_string(kmPercorsi) + "\n";
    tmp += m->toString();
    tmp += s->toString();
    return tmp;
}
