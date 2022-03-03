using System;
using System.Collections.Generic;
public class Months
{
    public static void main(string[] args)
    {
        string[] names = 
        { 
            "João",
            "Maria",
            "José",
            "Paula",
            "Pedro"
        };
        int i = 0;
        Random rand = new Random();
        List<int> listRandom = new List<int>();
        do {
            int valueRand = rand.Next(0, 5);
            bool exists = false;
            foreach (int item in listRandom)
            {
                if (item == valueRand)
                {
                    exists = true;
                }
            }
            if (!exists) {
                listRandom.Add(valueRand);
                i++;
                Console.WriteLine(i + " - " + names[valueRand]);
            }
        } while (i < names.Length);
    }
}