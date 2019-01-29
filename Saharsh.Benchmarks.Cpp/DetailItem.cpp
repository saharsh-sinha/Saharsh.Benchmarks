#include "pch.h"
#include "DetailItem.h"


DetailItem::DetailItem()
{
	age = 1;
	SubDetailItem sub();
}


DetailItem::~DetailItem()
{
}

SubDetailItem::SubDetailItem()
{
	age = 1;
	SubSubDetailItem subSub();
}

SubDetailItem::~SubDetailItem()
{
}

SubSubDetailItem::SubSubDetailItem()
{
	age = 1;
}

SubSubDetailItem::~SubSubDetailItem()
{
}
