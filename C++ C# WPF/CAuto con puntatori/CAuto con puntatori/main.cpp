#include "CAuto.h"
void main() {

	CMotore* m = new CMotore(10,2);
	CSerbatoio* s = new CSerbatoio(100, 0);
	CAuto a1(0, 4, m, s, "123456");
	cout << a1.toString();
	
}