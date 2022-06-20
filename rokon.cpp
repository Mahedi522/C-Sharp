Online C++ compiler to run C++ program online
#include <bits/stdc++.h>
using namespace std;
bool check(int a,int b) {
  int an=0;
  while(b) {
    an=an*10+b%10;
    b/=10;
  }
  if(an==a) return true;
  else return false;
}
// integer without using functions 
int convert(string s) 
{ 
    // Initialize a variable 
    int num = 0; 
    int n = s.length(); 
  
    // Iterate till length of the string 
    for (int i = 0; i < n; i++) 
  
        // Subtract 48 from the current digit 
        num = num * 10 + (int(s[i]) - 48); 
  
    // Print the answer 
    return num; 
}
int main() {
    int t,n;
    cin>>t;
    while(t--) {
      cout<<check(05,50)<<endl;
      string s;
      cin>>s>>n;
      string hh;
      hh.push_back(s[0]); hh.push_back(s[1]);
      int hr=convert(hh);
      string mm;
      mm.push_back(s[3]); mm.push_back(s[4]);
      int mn=convert(hh);
      int ans=0;
      int cnt=1440/n;
      while(cnt--) {
        if(check(hr,mn)) ans++;
        mn+=n;
        if(mn>59) {
          hr++;
          mn%=60;
        }
        if(hr>23) hr%=24;
      }
      cout<<ans<<endl;
    }

    return 0;
}