using Models;
using System;
using System.Collections.Generic;

namespace Controllers
{
    public class LeonCtrl 
    {
        public static void InsertLeon(int id, string name, int feed, int guest)
        {
            new Leon(id,name,feed,guest);
        }
        public static Leon UpdateLeon(int id, string name, int feed, int guest)
        {
            Leon leon = Leon.Leons.Find(leon => leon.IdAnim == id);

            if (leon == null) {
                throw new Exception("O Leão não foi encontrado.");
            }

            leon.NameAnim = name;
            leon.QtdFeed = feed;
            leon.Guests = guest;

            return leon;
        }

        public static Leon DeleteLeon(int id)
        {
            Leon leon = Leon.Leons.Find(leon => leon.IdAnim == id);

            if (leon == null) {
                throw new Exception("O Leão não foi encontrado.");
            }

            Leon.Leons.Remove(leon);

            return leon;
        }

        public static Leon PrintLeon(int id)
        {
            return Leon.PrintLeon(id);
        }

        public static List<Leon> GetLeons() 
        {
            return Leon.Leons;
        }
    }
}

//PrintLeon() LeonCtrl.cs -> Leon.cs