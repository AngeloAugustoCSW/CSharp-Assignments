using System;
using System.Collections.Generic;

public class Months
{
    public static void main(string[] args)
    {
		string[] months = {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"
        };
        Console.WriteLine("Digite o número do mês: ");
        int month = Convert.ToInt32(Console.ReadLine());
        if (month <= 0 || month > 12) {
            Console.WriteLine("Mês inválido");
            break;
        }
        Console.WriteLine("O mês é " + months[month - 1]);
    }
}