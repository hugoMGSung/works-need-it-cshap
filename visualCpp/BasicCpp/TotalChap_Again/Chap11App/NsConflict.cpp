#include <stdio.h>

namespace A {
	double value;
}

namespace B {
	int value;
}

int main()
{
	/*using namespace A;
	using namespace B;*/

	namespace aA = A;
	namespace bB = B;

	//value = 3;				// ��ȣ�ϴٴ� ���� �߻�
	aA::value = 3;
	A::value = 4;

	printf("%f\n", aA::value);
	printf("%f\n", A::value);
}