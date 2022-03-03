using System;
using System.Collections.Generic;
public class Months
{
    public static void main(string[] args)
    {
        HashSet<string> baralho = new HashSet<string>();
        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        string[] suits = { "Ouro", "Copas", "Espadas", "Paus" };
        foreach (string rank in ranks)
        {
            foreach (var suit in suits)
            {
                baralho.Add(rank + " " + suit);
            }   
        }
        foreach (string card in baralho)
        {
            Console.WriteLine(card);
        }
    }
}