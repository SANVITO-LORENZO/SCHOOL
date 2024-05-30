#include "CVettore.h"

CVettore::CVettore(int lunghezza,int numEl)
{
    setLunghezza(lunghezza);
    setNumEl(numEl);
    this->vett = new int[lunghezza];
}

CVettore::~CVettore()
{
}

CVettore::CVettore(const CVettore& other)
{
    this->lunghezza = other.lunghezza;
    this->numEl = other.numEl;
    this->vett = new int[this->lunghezza];
    for (int i = 0; i < this->numEl; i++)
    {
        this->vett[i] = other.vett[i];
    }
}

void CVettore::push(int num)
{
    if (numEl >= lunghezza)
    {
        ridimensiona(lunghezza+5);
    }
    vett[numEl] = num;
    numEl++;
}

int CVettore::pop()
{
    if (numEl > 0) {
        int tmp = vett[numEl - 1];
        numEl--;
        return tmp;
    }
    return INT_MIN;
}

int CVettore::get(int indice)
{
    return vett[indice];
}

int CVettore::getMax()
{
    int tmp = vett[0];
    for (int i = 1; i < numEl; i++)
    {
        if (tmp < vett[i])
            tmp = vett[i];
    }
    return tmp;
}

int CVettore::getMin()
{
    int tmp = vett[0];
    for (int i = 1; i < numEl; i++)
    {
        if (tmp > vett[i])
            tmp = vett[i];
    }
    return tmp;
}

int CVettore::getLunghezza()
{
    return lunghezza;
}

int CVettore::getNumEl()
{
    return numEl;
}

void CVettore::setLunghezza(int lunghezza)
{
    this->lunghezza  = lunghezza;
}

void CVettore::setNumEl(int numEl)
{
    this->numEl = numEl;
}

void CVettore::rotate(bool direzione)
{
    if (direzione) {
        int tmp = vett[0];
        for (int i = 0; i < numEl - 1; i++)
        {
            vett[i] = vett[i + 1];
        }
        vett[numEl - 1] = tmp;
    }
    else {
        for (int i = 0; i < numEl-1; i++)
        {
            int tmp = vett[0];
            for (int i = 0; i < numEl - 1; i++)
            {
                vett[i] = vett[i + 1];
            }
            vett[numEl - 1] = tmp;
        }
    }

}

void CVettore::shift(bool verso)
{ 
    if (verso)//sinistra 
    {
        int tmp = vett[0];
        for (int i = 0; i < numEl - 1; i++)
        {
            vett[i] = vett[i + 1];
        }
        vett[numEl - 1] = tmp;
    }
    else {//destra
        int tmp = vett[numEl-1];
        for (int i = 0; i < numEl; i++)
        {
            vett[numEl -i] = vett[numEl -i-1];
        }
        vett[0] = tmp;
    }
}

void CVettore::remove(int index)
{
    vett[index] = 0;
}

void CVettore::insert(int index, int value)
{
    numEl++;
    if (numEl == lunghezza) {
        ridimensiona(lunghezza + 10);
    }
    int tmp = vett[index];
    vett[index] = 0;
    for (int i = 0; i < numEl-index; i++)
    {
        vett[numEl - i] = vett[numEl - i - 1];
    }
    vett[index] = value;
    vett[index + 1] = tmp;
}

void CVettore::ridimensiona(int dimensione)
{
    int* v = new int[dimensione];
    for (int i = 0; i < lunghezza; i++)
    {
        v[i] = vett[i];
    }
    lunghezza = dimensione;
    delete[] vett;
    vett = v;
}

CVettore CVettore::eliminaDuplicati()
{
    //copio il vettore
    int j = 0;
    bool ripetizione = false;
    CVettore v = CVettore(numEl,0);
    for (int i = 0; i < numEl; i++)
    {
        v.push(vett[i]);
    }
    for (int i = 0; i < numEl; i++)
    {
        for (int x = 0; x < j; x++)
        {
            if (v.vett[x] == vett[i])
            {
                ripetizione = true;
                break;
            }
        }
        if (ripetizione)
        {
            ripetizione = false;
            continue;
        }
        v.vett[j] = vett[i];
        j++;
    }
    v.numEl = j;
    v.ridimensiona(true);
    return v;
}

CVettore CVettore::find(int numero)
{
    int tmp = 0;
    for (int i = 0; i < numEl; i++)
    {
        if (vett[i] == numero)
            tmp++;
    }
    CVettore v(tmp, 0);
    for (int i = 0; i < numEl; i++)
    {
        if (vett[i] == numero)
            v.push(i);
    }
    return v;
}

CVettore CVettore::sort(bool senso)
{
    int k = 0;
    int tmp = 0;
    do {
        k = 0;
        for (int i = 0; i < numEl - 1; i++)
            if (vett[i] > vett[i + 1])
            {
                tmp = vett[i];
                vett[i] = vett[i + 1];
                vett[i + 1] = tmp;
                k = 1;
            }
    } while (k == 1);

    CVettore v(numEl, 0);
    for (int i = 0; i < numEl; i++)
    {
        v.push(vett[i]);
    }
    return v;
}

CVettore CVettore::concatena(CVettore v2)
{
    CVettore v(getNumEl()+v2.getNumEl(), 0);
    for (int i = 0; i < getNumEl() + v2.getNumEl(); i++)
    {
        if (i < getNumEl())
            v.push(vett[i]);
        else
            v.push(v2.get(i - getNumEl()));
    }
    return v;
}

CVettore CVettore::intesezione(CVettore v2)
{
  
    CVettore v (contaUguali(v2),0);
    for (int i = 0; i < getNumEl(); i++)
    {
        for (int y = 0; y < v2.getNumEl(); y++)
        {
            if (vett[i] == v2.get(y))
            {
                v.push(v2.get(y));
            }
        }
    }
    return v;
}

//CVettore CVettore::unione(CVettore v2)
//{
//    CVettore v3(numEl + v2.getNumEl(), 0);
//    
//    return ;
//}

//CVettore CVettore::differenza(CVettore v2)
//{
//    for (int i = 0; i < numEl; i++)
//    {
//        for (size_t i = 0; i < v2.getNumEl(); i++)
//        {
//           
//        }
//    }
//}

bool CVettore::uguali(CVettore v2)
{
    bool tmp = 1;
    sort(1);
    v2.sort(1);
    for (int i = 0; i < numEl; i++)
    {
        if (vett[i] != v2.get(i))
            tmp = false;
    }
    return tmp;
}

int CVettore::contaUguali(CVettore v2)
{
      int tmp = 0;
      for (int i = 0; i < getNumEl(); i++)
       {
          for (int y = 0; y < v2.getNumEl(); y++)
           {
                if (vett[i] == v2.get(y))
                {
                    tmp++;
                }
            }
        }
       return tmp;
}

string CVettore::toString()
{
    string tmp = "";
    for (int i = 0; i < numEl; i++)
    {
        if (vett[i] >= 0)
            tmp += to_string(vett[i]) + "\t";
    }
    return tmp;
}
