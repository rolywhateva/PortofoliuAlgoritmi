// Laboratorul13.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
using namespace std;
struct nod {
	int info;
	nod *next;

};
void init(nod *&start, int value,nod *next) {

	start = new nod;
	start->info = value;
	start->next = next;

}
void addend(nod *&start, int value)
{
	if (start == NULL)
	{
		init(start, value,NULL);
		return;
	}
	nod *p = start;
	while (p->next != NULL)
		p = p->next;
	nod *nou;
	init(nou, value,NULL);
	p->next = nou;


}
void addbeg(nod *&start, int value)
{
	if (start == NULL)
	{
		init(start, value,NULL);
		return;
	}
	nod *nou;
	init(nou, value,start);
	start = nou;
}
int  dellbeg(nod *&start) {
	if (start != NULL)
	{
		nod *removed = start;
		int returned = removed->info;
		start = start->next;
		delete removed;
		return returned;

	}
}
int dellend(nod *&start)
{
	if (start != NULL)
	{
		nod *p = start;
		while (p->next->next != NULL)
			p = p->next;
		nod *removed = p->next;
		int returned = removed->info;
		p->next = NULL;
		delete removed;
		return returned;
	}
}
void view(nod *start)
{
	nod *p = start;
	while (p != NULL)
	{
		cout << p->info << " ";
		p = p->next;
	}
	cout << endl;
}
void addpoz(nod *start, int value, int poz)
{
	int i = 0;
	nod *p = start;
	while (p != NULL&& i+1 < poz)
	{
		p = p->next;
		i++;
	}
	if (p == NULL)
		cout << "Adaugarea a esuat";
	else
	{
		nod *nou = new nod;
		nou->info = value;
		nou->next = p->next;
		p->next = nou;


	}
}
int  delpoz(nod *start, int poz)
{
	if(start != NULL)
	{
		nod *p = start;
		int i = 0;
		while (p != NULL && i + 1 < poz)
		{
			p = p->next;
			i++;
		}
		nod *toRemove = p->next;
		p->next = p->next->next;
		int toReturn = toRemove->info;
		delete toRemove;
		return toReturn;
		 
	}
}
int main()
{
	nod *cap = NULL;

	for (int i = 0; i < 10; i++)
		addend(cap, i);
	for (int i = 0; i < 10; i++)
		addbeg(cap, -i);

	view(cap);

	dellend(cap);
	view(cap);
	dellbeg(cap);
	view(cap);
	delpoz(cap, 10);
	view(cap);
		 

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
