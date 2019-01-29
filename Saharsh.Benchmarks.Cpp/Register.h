#pragma once
#include <map>
#include "DetailItem.h"
class Register
{
public:
	Register();
	~Register();

	std::map<int, DetailItem*> items;
};

