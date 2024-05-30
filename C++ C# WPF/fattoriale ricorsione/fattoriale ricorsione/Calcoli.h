#pragma once
class Calcoli
{
private:
public:
	Calcoli(){};
	int getfattoriale(int num) {
		int tmp = 1;
		for (int i = 1; i < num; i++)
		{
			tmp += tmp * i;
		}
		return tmp;
	}

	int getFatRicorsione(int num) {
		if (num == 0)
			return 1;
		else
			return num * getFatRicorsione(num - 1);
	}
};

