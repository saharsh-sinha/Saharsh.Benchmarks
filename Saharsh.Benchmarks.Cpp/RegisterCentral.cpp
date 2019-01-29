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

void RegisterCentral::Benchmark(int lookups)
{
	int sum1 = 0;

	int sum2 = 0;
	RegisterCentral* regC = new RegisterCentral();
	std::clock_t c_start = std::clock();
	sum1 = getStraightSumofLookups(lookups);
	std::cout << sum1 << std::endl;
	std::cout << 1000 * float(clock() - c_start) / CLOCKS_PER_SEC << std::endl;

	c_start = std::clock();
	sum2 = getSumByRefLookup(lookups);
	std::cout << sum2 << std::endl;
	std::cout << 1000 * float(clock() - c_start) / CLOCKS_PER_SEC << std::endl;;

	c_start = std::clock();
	sum2 = getSumByDeepRefLookup(lookups);
	std::cout << sum2 << std::endl;
	std::cout << 1000 * float(clock() - c_start) / CLOCKS_PER_SEC << std::endl;;

	c_start = std::clock();
	sum1 = getSumByValLookup(lookups);
	std::cout << sum1 << std::endl;
	std::cout << 1000 * float(clock() - c_start) / CLOCKS_PER_SEC << std::endl;
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

int RegisterCentral::getSumByDeepRefLookup(int lookups)
{
	DetailItem* ptr = reg->items[1];
	int sum = 0;
	for (int i = 0; i < lookups; i++) {
		sum += ptr->sub.subsub.age;
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

