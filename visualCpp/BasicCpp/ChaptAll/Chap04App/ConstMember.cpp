#include <stdio.h>

class MathCalc {
private:
	const double pie;
public:
	double getPie() { return pie; }	
	MathCalc(double apie) :pie(apie) { ; }
	void DoCalc(double r) {
		printf("������ %.2f�� ���� �ѷ� = %.8f\n", r, 2 * r * pie);
	}
};

int main() {
	MathCalc m(3.141592);
	m.DoCalc(5.0);

}