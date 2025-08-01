#include "isogram.h"
#include <iostream>
#include <vector>
#include <algorithm>

bool isogram::is_isogram(std::string s){
	std::vector<char> v = std::vector<char>();
	std::transform(s.begin(), s.end(), s.begin(), ::tolower);
	for (char c : s){
		if(isalpha(c) && std::find(v.begin(), v.end(), c) != v.end()){
			return false;
		}
		v.push_back(c);
		std::cerr << std::string(v.begin(), v.end()) << std::endl;
	}
	return true;
}