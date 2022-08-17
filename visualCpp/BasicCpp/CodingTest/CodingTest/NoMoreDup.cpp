#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;

vector<int> solution(vector<int> arr)
{
    vector<int> answer;

    arr.erase(unique(arr.begin(), arr.end()), arr.end());
    answer = arr;
    // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
    cout << "Hello Cpp" << endl;

    return answer;
}

int main() {
    vector<int> inputs = { 1, 1, 3, 3, 0, 1, 1 };
    vector<int> outputs;

    for (int i = 0; i < inputs.size(); i++)
    {
        cout << inputs[i] << " ";
    }
    cout << endl;

    outputs = solution(inputs);
    for (int i = 0; i < outputs.size(); i++)
    {
        cout << outputs[i] << " ";
    } 
    cout << endl;
}