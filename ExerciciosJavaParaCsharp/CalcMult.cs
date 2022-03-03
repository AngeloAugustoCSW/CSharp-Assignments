using System;
					
public class CalcMult
{
	public static void Main()
	{
		int num, i;
		Console.WriteLine("Calculo Multiplicação");
		Console.WriteLine("Digite um número");
		num = Convert.ToInt32(Console.ReadLine());
		for(i=1;i<=10;i++)
		{
			Console.WriteLine("{0} * {1} = {2}", num, i, num*i);
			// tanto {n} ... {n+1} ou n + ... + n+1 funcionam no Console.WriteLine
		}
	}
}