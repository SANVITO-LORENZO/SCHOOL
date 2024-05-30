#pragma once
template <typename T>
class Vettore {

private:

    T* vett;
    int dimensione;

public:

    Vettore(int dimensione) {
        vett = new T[dimensione];
        this->dimensione = dimensione;
    }


    T& operator[](int i) {
        return vett[i];
    }

    Vettore<T>& operator+(const Vettore<T>& v) {
        Vettore<T> newVett(dimensione + v.dimensione);
        for (int i = 0; i < dimensione; i++) {
            newVett[i] = vett[i];
        }
        for (int i = dimensione; i < dimensione + v.dimensione; i++) {
            newVett[i] = v.vett[i - dimensione];
        }
        return newVett;
    }
};
