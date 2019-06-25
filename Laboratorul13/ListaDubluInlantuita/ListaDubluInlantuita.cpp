// ListaDubluInlantuita.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
using namespace std;
struct nod {
	int info;
	nod *st, *dr;
};
void init(nod *&cap, int value)
{
	cap = new nod;
	cap->dr = cap->st = NULL;
	cap->info = value;

}
void addend(nod *&cap, int value)
{
	if (cap == NULL)
	{
		init(cap, value);
		return;
	}
	nod *p = cap;
	while (p->dr != NULL)
		p = p->dr;

	nod *nou = new nod;
	nou->dr = NULL;
	nou->st = p;
	nou->info = value;

	p->dr = nou;

}
void addbeg(nod *&cap, int value)
{
	if (cap == NULL)
	{
		init(cap, value);
		return;
	}
	nod *nou = new nod;
	nou->info = value;
	nou->dr = cap;

	nou->st = NULL;
	cap->st = nou;
	cap = nou;
	

}
int dellbeg(nod *&cap)
{
	if (cap != NULL)
	{
		nod *toRemove = cap;
		cap = cap->dr;
		cap->st = NULL;
		int toReturn = toRemove->info;
		delete toRemove;
		return toReturn;
	}
}
int dellend(nod *&cap)
{
	if (cap != NULL)
	{
		nod *p = cap;
		while (p->dr->dr != NULL)
			p = p->dr;
		nod *removed = p->dr;
		p->dr->st = NULL;
		p->dr = NULL;
		int returned = p->info;
		delete removed;
		return returned;


	}
	else
	{
		cout << "Imposibil " << endl;
		return -1;
	}
}
void   addpoz(nod *&cap, int value, int poz)
{
	if (cap == NULL)
	{
		init(cap, value);
		return;
	}
	nod *p = cap;
	int i = 0;
	while (p != NULL && i + 1 < poz)
	{
		p = p->dr;
		i++;
	}
	if (p == NULL || poz < 0)
	{
		cout << "Pozitie ilegala" << endl;
	}
	else
	{
		nod *added = new nod;
		added->info = value;
		added->dr = p->dr;
		

		p->dr->dr = p->dr;
		added->st = p;

		
		
	}
}
int  delpoz(nod *&cap, int poz)
{
	if (cap != NULL)
	{
		nod *p = cap;
		int i = 0;
		while (p != NULL && i + 1 < poz)
		{
			p = p->dr;
			i++;
		}
		if (p == NULL || poz < 0)
		{
			cout << "Pozitie ilegala" << endl;
		}
		else
		{
			nod *removed = p->dr;
			p->dr = p->dr->dr;
			p->dr->st = p;
			int returned = removed->info;
			delete removed;
			return returned;




		}
	}
	else
	{
		cout << "Imposibil";
		return -1;
	}
}
void view(nod *cap) {
	nod *p = cap;
	while (p != NULL)
	{
		cout << p->info << " ";
		p = p->dr;
	}
	cout << endl;


}
void viewreverse(nod *cap)
{
	nod *p = cap;
	while (p->dr != NULL)
	{
		p = p->dr;
	}
	while (p!= NULL)
	{
		cout << p->info << " ";
		p = p->st;

	}
	cout << endl;

}
int main()
{
	nod *cap = NULL;
	
	for (int i = 0; i < 10; i++)
		addend(cap, i);
	view(cap);
	for (int i = 0; i < 10; i++)
		addbeg(cap, -i);
	view(cap);
	viewreverse(cap);

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
