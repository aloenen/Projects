﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Transaction
{
    private Dictionary<string, Item> items = new Dictionary<string, Item>();
    private int id;
    private Random rnd = new Random();
    private float total;
    private string customer;

    public float Total
    {
        get
        {
            return total;
        }
    }

    public Dictionary<string, Item> Items
    {
        get
        {
            return items;
        }
    }

    public string genReciept()
	{
        int d = rnd.Next(1, 31);
        string s = "\n************* Receipt ************\nDate: 6/" + d + "/18\nID: " + id + "\n\n";
        float t = 0;
        foreach(Item i in items.Values)
        {
            s += i.ToString() + "\n";
            t += i.Price*i.Amount;
        }
        total = t;
        s += "Total: $" + total + "\n**********************************\n";
        return s;
	}

	public Transaction(int i)
	{
        id = i;
	}

	public void addItem(string n, float p, int a)
	{
        if (items.ContainsKey(n))
        {
            items[n].Amount++;
        }
        else
        {
            items.Add(n, new Item(n, p, a));
        }      
	}

    public Item getItem(string name)
    {
        if(items.ContainsKey(name))
        {
            return items[name];
        }
        return null;
    }

}

