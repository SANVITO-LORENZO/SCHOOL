#pragma once
#include <string>
using namespace std;

class CVeicolo
{
private:
protected:
	string marca, targa, colore;
	int annoDiProduzione, prezzo;
public:
	//COSTRUTTORE
	CVeicolo(string m, string t, string c, int a, int p);
	//SET
	void setMarca(string m);
	void setTarga(string t);
	void setColore(string c);
	void setAnnoDiProduzione(int a);
	void setPrezzo(int p);
	//GET
	string getMarca();
	string getTarga();
	string getColore();
	int getAnnoDiProduzione();
	int getPrezzo();
	//METODI
	virtual string toString();

};

