#include <vector>
#include <unordered_map>
#include <iostream>
using namespace std;

int main() {
	int NumberList[5] = { 1, 2, 3, 4, 6 };

	/*for (int i = 0; i < 5; i++)
	{
		cout << NumberList[i] << ",";
	}
	cout << endl;

	for (int i = 5 - 1; i >= 0; i--)
	{
		cout << NumberList[i] << ",";
	}
	cout << endl;*/

	for (auto& i : NumberList)
	{
		cout << i << ",";
	}
	cout << endl;

	vector<int> VectorList = { 2, 4, 6, 8, 10 };
	for (auto& atom : VectorList)
	{
		cout << atom << ",";
	}
	cout << endl;
	
	unordered_map<int, string> MapList;
	MapList.insert(pair<int, string>(10, "first string"));
	MapList.insert(pair<int, string>(20, "second string"));
	MapList.insert(pair<int, string>(30, "third string"));
	MapList.insert(pair<int, string>(40, "fourth string"));
	MapList.insert(pair<int, string>(50, "fifth string"));

	for (auto& atom : MapList)
	{
		cout << atom.first << " / " << atom.second << endl;
	}
	cout << endl;

	return 0;
}