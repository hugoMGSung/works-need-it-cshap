#include <stdio.h>

namespace UTIL {
	int value;
	double score;
	void sub() { puts("sub routine"); }
}

namespace VeryVeryLongLongNameSpaceNameInTheWorld {
	/// --
	int value;
}

namespace MyCompany {
	namespace Research {
		namespace GameEngine {
			//....
		}
	}
}

int value;

int main() {
	// namespace MRG = com.google.app;
	namespace MRG = MyCompany::Research::GameEngine;
	namespace A = VeryVeryLongLongNameSpaceNameInTheWorld;
	using namespace UTIL;
	int value = 3;

	VeryVeryLongLongNameSpaceNameInTheWorld::value = 1;
	A::value = 2;

	UTIL::value = 4;
	UTIL::score = 1.234;
	UTIL::sub();

	return 0;
}

