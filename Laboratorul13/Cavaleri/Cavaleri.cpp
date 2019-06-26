// Cavaleri.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
using namespace std;

struct nod {
	int info;
	nod *dr;
	nod *st;
};
void init(nod *&cap, int val)
{
	cap = new nod;
	cap->info = val;
	cap->dr = cap;
	cap->st = cap;
}
void add(nod *&cap, int val)
{
	if (cap == NULL)
	{
		init(cap, val);
		return;
	}
	nod *nou = new nod;
	nod *last = cap->st;
	nou->info = val;
	nou->st = last;
	nou->dr = cap;
	last->dr = nou;
	cap->st = nou;



	



}
void view(nod *cap)
{
	nod *p = cap;
	do {
		cout << p->info << " ";
		p = p->dr;
	} while (p!= cap);
	cout << endl;
}
void del (nod *&cap)
{
	nod *last = cap->st;
	last->dr = cap->dr;
	cap->dr->st = last;
	nod *temp = cap;
	cap = cap->st;
	delete temp;
	


}
int main()
{
	
	int n;
	cout << "n=";
	cin >> n;
	
	nod *cap = NULL;
	for (int i = 1; i <= n; i++)
		add(cap, i);
	

	int count = n;
	int counter = 1, c = 0;
	nod *p = cap;
	view(cap);
	
	while (count > 1)
	{
		p = p->dr;
		
		c++;
		if (c >= counter)
		{
		
			if (p == cap)
			{
				nod *temp = cap;
				cap->st->dr = cap->dr;
				cap->dr->st = cap->st;
				cap = cap->dr;
				p = cap;
				delete temp;
			}
			else 
				/*
			if (p->dr == cap)
			{
				nod *temp = p;
				cap->dr = p->st;
				p->st->dr = cap;
				p->st->st = cap;
				p = cap;
				delete temp;

			}
			else
			*/
			del(p);
			
			view(cap);
			count--;
			counter++;
			c = 0;
		
		
		}
	}
	
	






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
