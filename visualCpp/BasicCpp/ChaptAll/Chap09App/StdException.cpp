#include <stdexcept>
#include <limits>
#include <iostream>
using namespace std;

void MyFunc(int c)
{
    if (c > 255) throw invalid_argument("[ERROR] MyFunc argument too large.");
    //...
}

int main() {
    try
    {
        MyFunc(256); // 에러 발생
    }
    catch (invalid_argument &e)
    {
        cerr << e.what() << endl;
        return -1;
    }
    //...
    return 0;
}