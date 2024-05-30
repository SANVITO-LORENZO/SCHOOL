#pragma once
#include"CMotore.h"
#include"CSerbatoio.h"
#include <string>
class CAuto
{
private:
	int numPosti;
	int kmPercorsi;
	string targa;
	CMotore* m;
	CSerbatoio* s;
public:
	CAuto(int kmPercorsi, int numPosti, CMotore* m, CSerbatoio* s,string targa);
	~CAuto();

	void setMotore(CMotore* m);
	void setSerbatoio(CSerbatoio* s);
	void setTarga(string targa);
	void setnumPosti(int numPosti);
	void setkmPercorsi(int kmPercorsi);

	string getTarga();
	int getnumPosti();
	int getkmPercorsi();

	float getAutonomia();
	void percorriKm(int Km);
	bool confontoAutonomia(CAuto a, CAuto b);
	bool confontoEconomia(CAuto a, CAuto b);

	string toString();

};

