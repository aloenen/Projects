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
using Project_4.GeneratedCode;

public class RebateManager
{
    public delegate void EnterRebateHandler(int id, DateTime date);
    public delegate void GenRebateHandler();

    Rebate rebate = new Rebate();

    EnterRebateHandler enterRebateHandler;
    GenRebateHandler genRebateHandler;

    RebateOutputView.Observer updateRebateOutput;
    uxForm.Observer updateGenerateRebateOutput;
    ModelI dataBase;

    public RebateManager(ModelI d)
    {
        dataBase = d;
        enterRebateHandler = new EnterRebateHandler(enterRebate);
        genRebateHandler = new GenRebateHandler(genRebate);
    }

	public void enterRebate(int id, DateTime date)
	{
        Transaction user = dataBase.getTransaction(id);
        bool valid;
        if (user == null)
        {
            valid = false;
        }
        else
        {
            valid = true;
        }
        if (dataBase.getRebate(id) != null && valid) 
        {
            float percentage = (float)11 / 100;
            rebate.RebateAmount = user.Total * percentage;           
        }

        updateRebateOutput(valid);
	}

	public void genRebate()
	{
        foreach(int key in dataBase.getRebates().Keys)
        {
            updateGenerateRebateOutput(key);
            dataBase.getRebates().Remove(key);
        }    
	}

    internal void register(RebateOutputView.Observer run1, uxForm.Observer run2)
    {
        updateRebateOutput = run1;
        updateGenerateRebateOutput = run2;
    }
}

