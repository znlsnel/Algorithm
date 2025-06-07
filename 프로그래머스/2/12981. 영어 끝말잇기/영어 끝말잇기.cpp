#include <string>
#include <vector>
#include <iostream>
#include <set>

using namespace std;

vector<int> solution(int n, vector<string> words) {

    
    set<string> s;
    
    for (int i = 0; i < words.size(); i++)
    {
        if (i > 0 && words[i].front() != words[i-1].back())
        {
            return {(i % n)+1, (i / n)+1};
        } 
        if (s.find(words[i]) != s.end())
        {  
            
            return {(i % n)+1, (i / n)+1};
            
        }
        s.insert(words[i]);
    }
    
    return {0, 0};   
}