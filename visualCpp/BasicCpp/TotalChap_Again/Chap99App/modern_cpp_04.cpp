#include <thread>
#include <iostream>
using namespace std;

int wmain(int argc, wchar_t* argv[]) {

	std::thread Thread1([]() {
		for (int i = 0; i < 5; i++)
		{
			std::cout << "Hello Thread " << i << std::endl;
		}
		});

	std::thread Thread2;
	Thread2 = std::thread([]() {
		for (int i = 10; i < 15; i++)
		{
			std::cout << "Hello Thread2 " << i << std::endl;
		}
		});

	std::thread Thread3 = std::thread([](int param) {
		for (int i = 20; i < 29; i++)
		{
			std::cout << "Hello Thread3 : " << i << " / " << param << std::endl;
		}
		}, 4);

	cout << "Thread1 id = " << Thread1.get_id() << endl;
	cout << "Thread2 id = " << Thread2.get_id() << endl;
	cout << "Thread3 id = " << Thread3.get_id() << endl;

	Thread1.detach();
	//Thread1.join();
	Thread2.join();
	Thread3.join();

	return EXIT_SUCCESS;
}