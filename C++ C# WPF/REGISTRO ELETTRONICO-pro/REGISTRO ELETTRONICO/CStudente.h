#pragma once
#include <string>
#include <iostream>
using namespace std;

class CStudente
{
private:
	//ATTRIBUTI
	float* vett;
	int numvoti;
	int maxvoti;
	string cognome;
public:
	//COSTRUTTORE
	CStudente(string cognome);
	CStudente(){};

	//SET
	void setNumVoti(int numvoti);
	void setMaxVoti(int maxvoti);
	void setCognome(string cognome);

	//GET
	int getNumVoti();
	int getMaxVoti();
	string getCognome();

	//METODI
	void addVoto(float voto);
	void ridimensiona(int newLunghezza);
	float getMedia();
	float getMax();
	float getMin();
	string toString();
};

