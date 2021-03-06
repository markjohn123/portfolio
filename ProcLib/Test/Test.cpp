// Test.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>   
#include <ProcLib.h>
#include <algorithm>  

#pragma comment(lib,"ProcLib.lib")

using namespace std;

void printmod(ProcessModule pm)
{

	wcout << "       " << pm.getName() << " " << (uint)pm.getBaseAddress() <<endl;
}

void print(Process p)
{

		wcout << p.getId() << " " << p.getName() << endl;
		ProcessModuleArray pm;
		if (p.getModules(&pm))
		{
			for_each(pm.begin(), pm.end(), printmod);
		}

}

int main()
{
	ProcessArray p;
	if (Process::getProcessesByName(L"ffxiv.exe",&p))
	{
		for_each(p.begin(), p.end(), print);
	}

	////wcout << p->back().getName();
	//HANDLE handle = OpenProcess(PROCESS_ALL_ACCESS, false, 15252);
	//wchar_t buffer[MAX_PATH];

	//GetModuleFileNameW((HMODULE)handle, buffer, MAX_PATH);
	//CloseHandle(handle);

	while (true);
    return 0;
}

