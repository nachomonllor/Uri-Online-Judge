#include <iostream>
#include <stdio.h>
 
using namespace std;
 
int main() {
   
    std::string s;
   while (std::getline(std::cin, s)){
       
        //string s = "  This   is         a  dancing   sentence  ";
 
        int j = 0;
        string ans = "";
        while (s[j] == ' ' && j < s.length()) {
            ans += " ";
            j++;
        }
        //Console.WriteLine(s[i]);
        bool mayus = true;
       
        for (int i = j; i < s.length(); i++)
        {
            if (s[i] != ' ')
            {
                if (mayus)
                {
                    ans += toupper(s[i]);
                }
                else
                {
                    ans += tolower(s[i]);
                }
                mayus = !mayus;
            }
            else
            {
                ans += " ";
            }
 
        }
 
        cout << ans << endl;
   
    }
   
 return 0;  
}
