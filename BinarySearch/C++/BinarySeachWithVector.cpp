#include <iostream>
#include <climits>
#include <vector>

using namespace std;

int BinarySearch(vector<int>& orderedArray, int targetValue) {
    
    int low = 0;
    int high = orderedArray.size() - 1;
    
    while (low <= high) {
        int midIndex = high + low / 2;
        int midValue = orderedArray[midIndex];
        
        if (midValue == targetValue) {
            cout << "Value " << targetValue << " was found on the array position " << midIndex << endl;
            return midIndex;
        }
        else if (midValue < targetValue) {
            low = midIndex + 1;
        }
        else if (midValue > targetValue) {
            high = midIndex - 1;
        }
    }
    
    cout << "Value " << targetValue << " was not found on the array" << endl;
    return INT_MAX;
}

int main()
{
    vector<int> array = {1, 2, 3};
    BinarySearch(array, 2);
    
    return 0;
}
