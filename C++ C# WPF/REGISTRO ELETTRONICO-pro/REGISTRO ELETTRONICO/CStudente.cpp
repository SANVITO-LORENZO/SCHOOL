#include "CStudente.h"

CStudente::CStudente(string cognome)
{
    vett = new float[10];
    setNumVoti(0);
    setMaxVoti(10);
    setCognome(cognome);
}

void CStudente::setNumVoti(int numvoti)
{
    this->numvoti = numvoti;
}

void CStudente::setMaxVoti(int maxvoti)
{
    this->maxvoti = maxvoti;
}

void CStudente::setCognome(string cognome)
{
    this->cognome = cognome;
}

int CStudente::getNumVoti()
{
    return numvoti;
}

int CStudente::getMaxVoti()
{
    return maxvoti;
}

string CStudente::getCognome()
{
    return cognome;
}

void CStudente::addVoto(float voto)
{
    if(voto>0||voto<=10){

        if (numvoti == maxvoti)
            ridimensiona(maxvoti * 2);
        vett[numvoti] = voto;
        numvoti++;
    }
}

void CStudente::ridimensiona(int newLunghezza)
{
    float* v = new float[newLunghezza];
    for (int i = 0; i < numvoti; i++)
    {
        v[i] = vett[i];
    }
    delete[]vett;
    vett = v;
    maxvoti = newLunghezza;
}

float CStudente::getMedia()
{
    float tmp = 0.0;
    for (int i = 0; i < numvoti; i++)
    {
        tmp += vett[i];
    }
    return tmp/numvoti;
}

float CStudente::getMax()
{
    float tmp = vett[0];
    for (int i = 1; i < numvoti; i++)
    {
        if(vett[1]>tmp)
        tmp = vett[i];
    }
    return tmp;
}

float CStudente::getMin()
{
    float tmp = vett[0];
    for (int i = 1; i < numvoti; i++)
    {
        if (vett[1] < tmp)
            tmp = vett[i];
    }
    return tmp;
}

string CStudente::toString()
{
    string tmp = "";
    for (int i = 0; i < numvoti; i++)
    {
        tmp += to_string(vett[i]) + "\t";
    }
    tmp += "\n";
    return tmp;

}
