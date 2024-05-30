#include "CVettore.h"

CVettore::CVettore(int l)
{
    this->vettore = new int[l];
    setLunghezza(l);
    this->numEl=0;
}

CVettore::~CVettore()
{

}

void CVettore::push(int num)
{
    if (numEl >= l)
    {
        ridimensiona(5);
    }
    vettore[numEl] = num;
    numEl++;

}

int CVettore::pop()
{
    if (numEl > 0) {
        int tmp = vettore[numEl - 1];
        numEl--;
        return tmp;
    }
    return INT_MIN;

}

void CVettore::ridimensiona(int dimensione)
{
        l = dimensione;
        int* v = new int(l);
        for (int i = 0; i < l - dimensione; i++)
        {
            v[i] = vettore[i];
        }
        delete[]vettore;
        vettore = v;
}

int CVettore::get(int i)
{
    return vettore[i];
}

void CVettore::rotate(bool direzione, int numEl)
{
    int num = numEl - 1;
    for (int i = 0; i < numEl / 2; i++)
    {
        int tmp1 = vettore[i];
        int tmp2 = vettore[num];
        vettore[num] = tmp1;
        vettore[i] = tmp2;
        num--;
    }
}

string CVettore::toString()
{
    string tmp = "";
    for (int i = 0; i < numEl; i++)
    {
        if (vettore[i]>=0)
            tmp += to_string(vettore[i]) + "\t";
    }
    return tmp;
}

CVettore CVettore::find(int numero)
{
    int tmp = 0;
    for (int i = 0; i < l; i++)
    {
        if (tmp == vettore[i])
            tmp++;
    };
    int* v = new int[tmp];
    int y = 0;
    for (int i = 0; i < l; i++)
    {
        if (tmp == vettore[i]) 
        {
        v[y] = i;
        y++;
        }
    }
    return *v;
}

CVettore CVettore::sort(bool senso)
{
    for (int i = 0; i < numEl; i++)
    {
        for (int j = i + 1; j < numEl; j++)
        {
            if (vettore[i] > vettore[j]) {
                int tmp1 = vettore[i];
                int tmp2 = vettore[j];
                vettore[j] = tmp1;
                vettore[i] = tmp2;
            }
        }
    }
    ;
}

void CVettore::shift(bool verso, int index)
{

}

void CVettore::remove(int index)
{
    vettore[index] = 0;
    shift(false, index);
}

void CVettore::insert(int index, int value)
{
    //int tmp = index;
    //numEl++;
    //for (int i = 0; i < l-tmp; i++)
    //{
    //    int num = vettore[index + 1];

    //    vettore[index] = vettore[index - 1];
    //    index++;
    //}
    //vettore[tmp-1] = value;
    shift(true, index);
    vettore[index] = value;
    numEl++;
}

void CVettore::eliminaDuplicati()
{
}

int CVettore::getMax()
{
    int tmp = vettore[0];
    for (int i = 1; i < l; i++)
    {
        if (tmp < vettore[i])
            tmp = vettore[i];
    }
    return tmp;
}

int CVettore::getMin()
{
    int tmp = vettore[0];
    for (int i = 1; i < l; i++)
    {
        if (tmp > vettore[i])
            tmp = vettore[i];
    }
    return tmp;
}

int CVettore::getLunghezza()
{
    return l;
}

void CVettore::setLunghezza(int lunghezza)
{
    this->l = lunghezza;
}


