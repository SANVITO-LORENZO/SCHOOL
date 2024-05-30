#include"CRegistroElettronico.h"
#include<ctime>
void main() {
	srand(time(NULL));

	CStudente* s1 = new CStudente("pablito");
	for (int i = 0; i < 10; i++)
	{
		s1->addVoto(rand() % 10 + 1);
	}

	CStudente* s2 = new CStudente("bob");
	for (int i = 0; i < 10; i++)
	{
		s2->addVoto(rand() % 10 + 1);
	}

	CStudente* s3 = new CStudente("mattiuw");
	for (int i = 0; i < 10; i++)
	{
		s3->addVoto(rand() % 10 + 1);
	}

	CStudente* s4 = new CStudente("alex");
	for (int i = 0; i < 10; i++)
	{
		s4->addVoto(rand() % 10 + 1);
	}

	CRegistroElettronico* reg = new CRegistroElettronico(1);

	reg->addStudente(s1);
	reg->addStudente(s2);
	reg->addStudente(s3);
	reg->addStudente(s4);

	cout << reg->toString() << endl;
	cout << reg->votoMax() << endl;
	cout << reg->votoMin() << endl;
	cout << reg->mediVoti() << endl;
	cout << "SORT MEDIA" << endl;
	reg->ordinaMedia();
	cout << reg->toString() << endl;
	cout << "SORT COGNOME" << endl;
	reg->ordinaCognome();
	cout << reg->toString() << endl;

}