#pragma once

#include "Register.h"

class RegisterCentral
{
private:
	Register* reg;
public:
	RegisterCentral();
	~RegisterCentral();

	void Benchmark(int lookups);

	int getSumByValLookup(int lookups);
	int getSumByRefLookup(int lookups);
	int getSumByDeepRefLookup(int lookups);
	int getStraightSumofLookups(int lookups);
	
};

