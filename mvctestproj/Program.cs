using System;
using View;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvctestproj
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int chc =0;
            do 
            {
                Console.Clear();
                Console.WriteLine("Teste de modelo MVC");
                Console.WriteLine("[1] - Insert lion");
                Console.WriteLine("[2] - Delete lion");
                Console.WriteLine("[3] - Update lion");
                Console.WriteLine("[4] - Select lion");
                Console.WriteLine("[5] - Select all lions");
                Console.WriteLine("[6] - Exit program");
                Console.Write("\nENTER OPTION: ");
                try
                {
                chc = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Not a int, try again");
                    Console.ReadKey();
                }
                switch(chc)
                {
                    case 1:
                        Console.WriteLine("[INSERT LION]");
                        LeonView.InsertLeon();
                        Console.ReadKey();
                        break;
                    
                    case 2:
                        Console.WriteLine("[DELETE LION]");
                        LeonView.DeleteLeon();
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.WriteLine("[UPDATE LION]");
                        LeonView.UpdateLeon();
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine("[SELECT LION]");
                        LeonView.PrintLeon();
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("[SELECT ALL LIONS]");
                        LeonView.PrintLeons();
                        Console.ReadKey();
                        break;
                }
            }
            while(chc!=6);
            Console.Clear();
        }
    }
}
