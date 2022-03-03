using System;
using System.Collections.Generic;
using System.Numerics;

public class BasicOperations
{
    public static void main(string[] args)
    {
		int NumOne = 0, NumTwo = 0;
        Console.WriteLine("Operações basicas");
        Console.Write("Digite o primeiro valor: ");
        try
        {
            NumOne = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.Exception ex)
        {
             Console.WriteLine("Valor não é um numero");
        }

        Console.Write("Digite o segundo valor: ");
        try
        {
            NumTwo = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.Exception ex)
        {
             Console.WriteLine("Valor não é um numero");
        }
        Console.WriteLine("Digite a operação (| + | - | * | / |): ");
        string operacao = Console.ReadLine();
        if (operacao.Equals("+"))
        {
            Console.WriteLine(NumTwo + NumOne);
        }
        else if (operacao.Equals("-"))
        {
            Console.WriteLine(NumTwo - NumOne);
        }
        else if (operacao.Equals("*"))
        {
            Console.WriteLine(NumTwo * NumOne);
        }
        else if (operacao.Equals("/"))
        {
            Console.WriteLine(NumTwo / NumOne);
        }
        else 
        {
            Console.WriteLine("Operação inválida");
        }
    }
}