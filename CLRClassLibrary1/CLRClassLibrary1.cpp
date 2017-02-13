// This is the main DLL file.

#include "stdafx.h"

#include "CLRClassLibrary1.h"

namespace CLRClassLibrary1 {
	int Class1::Method1()
	{
		a = 1;
		b = 10;
		return a + b;
	}
}
