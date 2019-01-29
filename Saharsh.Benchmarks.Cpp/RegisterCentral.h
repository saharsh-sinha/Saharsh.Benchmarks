#pragma once

#include "Register.h"

class RegisterCentral
{
private:
	Register* reg;
public:
	RegisterCentral();
	~RegisterCentral();

	int getSumByValLookup(int lookups);
	int getSumByRefLookup(int lookups);
	int getStraightSumofLookups(int lookups);
	
};

