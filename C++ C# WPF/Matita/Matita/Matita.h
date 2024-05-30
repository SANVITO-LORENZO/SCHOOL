#pragma once
#include <string>
using namespace std;

class Matita
{
private:
    int lunghezza;
public:
    Matita();
    Matita(int l);
    int getLunghezza();
    void tempera();
    void tempera(int volte); //overloading
    virtual string toString(); //serve virtual altrimenti non viene richiamato il toString della sottoclasse nel main
};

