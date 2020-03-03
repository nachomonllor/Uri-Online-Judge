#include <iostream>
#include <stdio.h>

using namespace std;


int main() {
	
	
   int a;
   while (scanf("%d", &a) != EOF)
   {
   		if(a == 0) {
   			cout << "vai ter copa!" << endl;
		}
		else{
			cout << "vai ter duas!" << endl;
		}
   }
	
	
	return 0;
}