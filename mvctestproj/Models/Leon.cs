using System;
using System.Collections.Generic;
using System.Linq;
using Controllers;

namespace Models
{
     public class Leon : Animal
    {
        public static List<Leon> Leons = new List<Leon>();
        public int QtdFeed { get; set; }
        public int Guests { get; set; }
        public Leon (int IdAnim, string NameAnim, int QtdFeed, int Guests) : base (IdAnim, NameAnim)
        {
            this.QtdFeed = QtdFeed;
            this.Guests = Guests;

            Leons.Add(this);
        }

        public static Leon PrintLeon(int id)
        {
            return (from Leon in Leon.Leons
                    where Leon.IdAnim == id
                    select Leon).First();
        }
        public override string ToString()
        {
            return $"Id: {base.IdAnim}\n"
                  +$"Nome: {base.NameAnim}\n"
                  +$"Alimentação: {this.QtdFeed}\n"
                  +$"Visitantes: {this.Guests}\n";
        }
    }
}