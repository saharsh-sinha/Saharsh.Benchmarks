// Rishu.Benchmarks.Cpp.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>

#include "RegisterCentral.h"

using namespace std;

int main()
{
    std::cout << "Hello World!\n"; 

	int lookups = 10000000;
	int sum1 = 0;

	int sum2 = 0;
	RegisterCentral* regC = new RegisterCentral();
	std::clock_t c_start = std::clock();
	sum1 = regC->getStraightSumofLookups(lookups);
	std::cout << sum1 << std::endl;
	std::cout << 1000 * float(clock() - c_start) / CLOCKS_PER_SEC << std::endl;
	
	c_start = std::clock();
	sum2 = regC->getSumByRefLookup(lookups);
	std::cout << sum2 << std::endl;
	std::cout << 1000 * float(clock() - c_start) / CLOCKS_PER_SEC << std::endl;;

	c_start = std::clock();
	sum1 = regC->getSumByValLookup(lookups);
	std::cout << sum1 << std::endl;
	std::cout << 1000 * float(clock() - c_start) / CLOCKS_PER_SEC << std::endl;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
