#include <iostream>
#include <stdio.h>

using namespace std;

int main() {
	
	int t;
	scanf("%d", &t);

    double max_nota = 0;
    int max_alum = -1;
    while (t--)
    {
        //double x = double.Parse(Console.ReadLine().Trim());
        //string[] input = Console.ReadLine().Trim().Split(' ');
        int num_alum; // = int.Parse(input[0]);
        double nota; // = Convert.ToDouble(input[1]); //double.Parse(input[1]);
        
        scanf("%d %lf", &num_alum, &nota);
        
        if (nota >= 8.0)
        {
            if (nota > max_nota)
            {
                max_nota = nota;
                max_alum = num_alum;
            }
        }

    }
    if (max_nota == 0)
    {
        cout << ("Minimum note not reached") << endl;
    }
    else
    {
        cout << (max_alum) << endl;
    }
	
	return 0;
}