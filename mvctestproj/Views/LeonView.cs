using Models;
using Controllers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace View
{
    public class LeonView
    {
        public static void InsertLeon()
        {
            Console.WriteLine("Digite o ID do Leão: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Nome do Leão: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de alimentação do Leão: ");
            int feed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os visitantes do Leão: ");
            int guest = Convert.ToInt32(Console.ReadLine());

            Controllers.LeonCtrl.InsertLeon(id, name, feed, guest);
        }
        public static void UpdateLeon()
        {
            Console.WriteLine("Digite o ID do Leão: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Nome do Leão: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de alimentação do Leão: ");
            int feed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os visitantes do Leão: ");
            int guest = Convert.ToInt32(Console.ReadLine());

            try
            {
                Controllers.LeonCtrl.UpdateLeon(id, name, feed, guest);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteLeon()
        {
            Console.WriteLine("Digite o ID do Leão: ");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                Controllers.LeonCtrl.DeleteLeon(id);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void PrintLeons() 
        {
            foreach (Leon item in Controllers.LeonCtrl.GetLeons())
            {
                Console.WriteLine(item);
            }
        }
        
        public static void PrintLeon()
        {
            Console.WriteLine("Digite o ID do Leão: ");
            int id = Convert.ToInt32(Console.ReadLine());
            try{
                Console.WriteLine(
                    (from Leon in Leon.Leons
                        where Leon.IdAnim == id
                        select Leon
                    ).First()
                );
            }
            catch
            {
                Console.WriteLine("Leão não encontrado.");
            }
        }
    }
}

//PirntLeon() -> LeonCtrl.cs