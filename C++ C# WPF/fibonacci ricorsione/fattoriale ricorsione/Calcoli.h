#pragma once
class Calcoli
{
private:
	int* vett;
	int numel;
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

	int fibonacci(int n) {
		if (n == 0) {
			return 0;
		}
		else if (n == 1) {
			return 1;
		}
		else {
			return fibonacci(n - 1) + fibonacci(n - 2);
		}
	}
};

