// Matita.cpp : Questo file contiene la funzione 'main', in cui inizia e termina l'esecuzione del programma.
//

#include <iostream>
#include "MatitaGommino.h"
#include "Astuccio.h"

int main()
{
    MatitaGommino matitaGommino(12);
   /* cout << "Lunghezza: " << matitaGommino.getLunghezza() << endl;
    cout << "Cancellature: " << matitaGommino.getCancellature() << endl;*/

    cout << matitaGommino.toString();
    matitaGommino.cancella();
    matitaGommino.tempera();
    cout << matitaGommino.toString();
    for (int i = 0; i < 8; i++) {
        matitaGommino.cancella();
        matitaGommino.tempera();
    }
       
    
    cout << matitaGommino.toString();
    cout << "----------------------\n";

    Astuccio astuccio(true); //con false astuccio vuoto, true astuccio pieno
    cout << astuccio.toString();
    astuccio.addMatita(matitaGommino);
    cout << astuccio.toString();

    int i;
    cout << "Che matita vuoi: ";
    cin >> i;
    cout << "\nMatita in posizione " << i << ":\n"<< astuccio.getMatita(i).toString(); //non stampa bene

}
