#include <iostream>
#include <stdio.h>
#define lli long long int 

using namespace std;

int main() {
	
	lli x;
	cin >> x;
	
	lli rev = 0;
	
	while(x > 0) {
		rev = rev * 10 + (x % 10);
		x /= 10;
	}
	
	cout << rev << endl;
	
	return 0;
}