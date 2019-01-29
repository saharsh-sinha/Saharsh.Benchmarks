#include "pch.h"
#include "RegisterCentral.h"


RegisterCentral::RegisterCentral()
{
	reg = new Register();
	reg->items.insert(std::pair<int, DetailItem*>(1, new DetailItem()));
}


RegisterCentral::~RegisterCentral()
{
}

int RegisterCentral::getSumByValLookup(int lookups)
{
	int sum = 0;
	for (int i = 0; i < lookups; i++) {
		sum += reg->items[1]->age;
	}
	return sum;
}

int RegisterCentral::getSumByRefLookup(int lookups)
{
	DetailItem* ptr = reg->items[1];
	int sum = 0;
	for (int i = 0; i < lookups; i++) {
		sum += ptr->age;
	}
	return sum;
}


int RegisterCentral::getStraightSumofLookups(int lookups)
{
	int sum = 0;
	for (int i = 0; i < lookups; i++) {
		sum += 1;
	}
	return sum;
}

