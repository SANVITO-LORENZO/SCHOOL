#include "CRegistroElettronico.h"

CRegistroElettronico::CRegistroElettronico(int maxel)
{
	this->numel = 0;
	this->maxel = maxel;
	vett = new CStudente[maxel];
}


void CRegistroElettronico::ridimensiona(int nuovalunghezza) 
{
	CStudente* v = new CStudente[nuovalunghezza];
	for (int i = 0; i < numel; i++)
	{
		v[i] = vett[i];
	}
	maxel = nuovalunghezza;
	delete[]vett;
	vett = v;
}

void CRegistroElettronico::addStudente(CStudente* s)
{
	if (numel == maxel) {
		ridimensiona(maxel * 2);
	}
	vett[numel] = *s;
	numel++;
}

string CRegistroElettronico::mediVoti()
{
	string tmp = "";
	for (int i = 0; i < numel; i++)
	{
		tmp += vett[i].getCognome() + "\t--->\t ";
		tmp += "media: " + to_string(vett[i].getMedia()) + "\n";
	}
	return tmp;
}

string CRegistroElettronico::votoMax()
{
	string tmp = "";
	for (int i = 0; i < numel; i++)
	{
		tmp += vett[i].getCognome() + "\t--->\t";
		tmp += "voto max: " + to_string(vett[i].getMax()) + "\n";
	}
	return tmp;
}

string CRegistroElettronico::votoMin()
{
	string tmp = "";
	for (int i = 0; i < numel; i++)
	{
		tmp += vett[i].getCognome() + "\t--->\t";
		tmp += "voto min: " + to_string(vett[i].getMin()) + "\n";
	}
	return tmp;
}

void CRegistroElettronico::ordinaMedia()
{
	for (int i = 0; i < numel; i++)
	{
		for (int y = 0; y < numel-1; y++)
		{
			if (vett[y].getMedia() > vett[y+1].getMedia()){
				CStudente tmp = vett[y];
				vett[y] = vett[y + 1];
				vett[y + 1] = tmp;
			}
		}
	}
}

void CRegistroElettronico::ordinaCognome()
 {
	for (int i = 1; i < numel; i++) {			
		for (int j = 0; j < i; j++) {
			if (vett[i].getCognome() < vett[j].getCognome()) {
				string temp = vett[i].getCognome();
				vett[i] = vett[j];
				vett[j] = temp;
			}
		}
	}
}

string CRegistroElettronico::toString()
{
	string tmp="";
	for (int i = 0; i < numel; i++)
	{
		tmp += "STUDENTE " + to_string(i + 1) + "\t--->\t";
		tmp += vett[i].getCognome()+"\n";
	}
	return tmp;
}
