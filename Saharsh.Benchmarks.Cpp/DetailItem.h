#pragma once

class SubSubDetailItem
{
public:
	SubSubDetailItem();
	~SubSubDetailItem();
	int id;
	int age;
};

class SubDetailItem
{
public:
	SubDetailItem();
	~SubDetailItem();
	int id;
	int age;
	SubSubDetailItem subsub;
};

class DetailItem
{
public:
	DetailItem();
	~DetailItem();
	int id;
	int age;
	SubDetailItem sub;
};

