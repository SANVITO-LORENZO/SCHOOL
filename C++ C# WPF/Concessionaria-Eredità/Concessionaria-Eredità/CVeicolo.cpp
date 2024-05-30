#include "CVeicolo.h"

CVeicolo::CVeicolo(string m, string t, string c, int a, int p)
{
    setMarca(m);
    setTarga(t);
    setColore(c);
    setAnnoDiProduzione(a);
    setPrezzo(p);
}

void CVeicolo::setMarca(string m)
{
    this->marca = m;
}

void CVeicolo::setTarga(string t)
{
    this->targa = t;
}

void CVeicolo::setColore(string c)
{
    this->colore = c;
}

void CVeicolo::setAnnoDiProduzione(int a)
{
    this->annoDiProduzione = a;
}

void CVeicolo::setPrezzo(int p)
{
    this->prezzo = p;
}

string CVeicolo::getMarca()
{
    return marca;
}

string CVeicolo::getTarga()
{
    return targa;
}

string CVeicolo::getColore()
{
    return colore;
}

int CVeicolo::getAnnoDiProduzione()
{
    return annoDiProduzione;
}

int CVeicolo::getPrezzo()
{
    return prezzo;
}

string CVeicolo::toString()
{
    string tmp = "";
    tmp += "Marca: " + marca + "\n";
    tmp += "Targa: " + targa + "\n";
    tmp += "Colore: " + colore + "\n";
    tmp += "Anno di produzione: " + to_string(annoDiProduzione) + "\n";
    tmp += "Prezzo: " + to_string(prezzo) + "\n";
    return tmp;
}
