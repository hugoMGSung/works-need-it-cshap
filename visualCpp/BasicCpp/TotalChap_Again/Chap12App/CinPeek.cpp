// istream::peek example
#include <iostream>     // cin, cout
#include <string>       // string
#include <cctype>       // isdigit
using namespace std;

int main() {

    cout << "Please, enter a number or a word: ";
    cout.flush();    // ensure output is written

    cin >> ws;  // eat up any leading white spaces
    int c = cin.peek();  // peek character

    if (c == EOF) return 1;
    if (isdigit(c))
    {
        int n;
        cin >> n;
        cout << "You entered the number: " << n << endl;
    }
    else
    {
        string str;
        cin >> str;
        cout << "You entered the word: " << str << endl;
    }

    return 0;
}