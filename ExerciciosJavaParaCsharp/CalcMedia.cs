using System;

public class CalcMedia
{
	public static void Main(string[] args)
	{
		int nt1, nt2, nt3, med;
		Console.WriteLine("Calculo media");
		Console.WriteLine("Digite 3 notas");
		nt1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Digite mais 2 notas");
		nt2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Digite a ultima notas");
		nt3 = Convert.ToInt32(Console.ReadLine());
		med = (nt1 + nt2 + nt3) / 3;
		Console.WriteLine("Media: {0}", med);
	}
}