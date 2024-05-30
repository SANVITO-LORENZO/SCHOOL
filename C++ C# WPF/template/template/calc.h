#pragma once
#include <iostream>
#include <string>

template <typename CAL>
class calc
{
public:
    static CAL somma(CAL N1, CAL N2)
    {
        return N1 + N2;
    }

    static CAL differenza(CAL arg1, CAL arg2)
    {
        return arg1 - arg2;
    }

    static CAL divisione(CAL arg1, CAL arg2)
    {
        return arg1 / arg2;
    }

    static CAL moltiplicazione(CAL arg1, CAL arg2)
    {
        return arg1 * arg2;
    }
};