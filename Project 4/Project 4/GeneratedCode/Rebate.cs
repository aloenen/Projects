using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Rebate
{
    private int transID;
    private float transAmount;
    private DateTime date;
    private float rebateAmount;
    
    public DateTime Date
    {
        get
        {
            return date;
        }
        set
        {
            date = value;
        }
    }

    public float TransAmount
    {
        set
        {
            transAmount = value;
        }
    }

    public float RebateAmount
    {
        set
        {
            rebateAmount = value;
        }
    }

    public int TransID
    {
        get
        {
            return transID;
        }
        set
        {
            transID = value;
        }
    }

    public override string ToString()
    {
        return "Transaction: " + transID + "\nDate: " + date.ToString() + "\nSavings: $" + (rebateAmount * transAmount);
    }

}

