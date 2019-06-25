// ListaCirculara.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
using namespace std;
struct nod {
	int info;
	nod *next;
};
void init(nod *&cap, int val)
{
cap = new nod;
cap->info = val;
cap->next = cap;
}
void add(nod *&cap, int val)
{
	if (cap == NULL)
	{
		init(cap, val);
		return;
	}
	nod *p = cap;
	do {
		p = p->next;
	} while (p->next != cap);
	nod *nou = new nod;
	nou->info = val;
	nou->next = cap;
	p->next = nou;


}
void view(nod *cap)
{
	nod *p = cap;
	do {
		cout << p -> info << " ";
		p = p->next;
	} while (p != cap);
 
}
void del(nod *&cap)
{
	if (cap == NULL)
	{
		cout << "Imposibil" << endl;
		return;
	 }
	nod *p = cap;
	do {
		p = p->next;
	} while (p->next->next != cap);
	nod *toRemove = cap;
	p->next->next = cap->next;
	cap = cap->next;
	delete toRemove;
	
}


int main()
{
	nod *cap = NULL;
	for (int i = 0; i < 10; i++)
		add(cap, i);
	view(cap);
	del(cap);
	cout << endl;
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
