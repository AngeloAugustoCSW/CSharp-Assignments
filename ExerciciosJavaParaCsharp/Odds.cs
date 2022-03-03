using System;
					
public class Odds
{
	public static void Main()
	{
		Console.WriteLine("Somatória de números ímpares divisiveis por 7 entre 1 a 500");
		int sum=0, i=0;
		for(i=1;i<=500;i++)
		{
			if((i%2!=0)&&(i%7==0))
			{
				sum+=i;
			}
		}
		Console.WriteLine("A some dos números ímpares, divisel por 7, entre 1 a 500 é: "+sum);
	}
}