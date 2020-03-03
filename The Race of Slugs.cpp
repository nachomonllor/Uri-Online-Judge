#include <iostream>
#include <stdio.h>
#include <limits.h>

using namespace std;


int main() {
	
	int n;
	
	while (scanf("%d", &n) != EOF) 
	{	
		int m = INT_MIN;
		for(int i =0; i<n; i++) {
			int elem;
			scanf("%d", &elem);
			m = max(m, elem);
		}
		
        if (m < 10) cout << "1" << endl;
        else if (m < 20) cout << "2" << endl;
        else cout << "3" << endl;	
	}		
	
	return 0;
}