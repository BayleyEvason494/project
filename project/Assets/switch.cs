using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// C# program to illustrate 
// switch case statement 
using System;

public class GFG
{

    // Main Method 
    public static void Main(String[] args)
    {
        int nitem = 5;
        switch (nitem)
        {

            case 1:
                Console.WriteLine("case 1");
                break;

            case 5:
                Console.WriteLine("case 5");
                break;

            case 9:
                Console.WriteLine("case 9");
                break;

            default:
                Console.WriteLine("No match found");
                break;
        }
    }
}
