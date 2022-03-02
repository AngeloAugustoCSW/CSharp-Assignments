using System;
using System.Collections.Generic;

namespace Models
{
    public class Procedimento
    {
        public static int ID = 0;
        public int Id { get; set; }
        public string Desc { get; set; }
        public double Price { get; set; }
        private static List<Procedimento> Procedimentos = new List<Procedimento>();

        public Procedimento(
            string Desc,
            double Price) 
            : this(++ID, Desc, Price)
        {
        }

        private Procedimento(
            int id,
            string Desc,
            double Price
        )
        {
            this.Id = Id;
            this.Desc = Desc;
            this.Price = Price;
        }
        public static List<Procedimento> GetProcedimentos()
        {
            return Procedimentos;
        }
        public static void RemoverProcedimento(Procedimento procedimento)
        {
            Procedimentos.Remove(procedimento);
        }
        public override bool Equals(object o)
        {
            if(o == null)
            {
                return false;
            }
            if (!Procedimento.ReferenceEquals(o, this))
            {
                return false;
            }
            Procedimento p = (Procedimento) o;
            return p.Id == this.Id;
        }
        public override string ToString()
        {
            return$"\n ---------------------------------------"
                  +$"ID: {this.Id}"
                  +$"\n Descrição: {this.Desc}"
                  +$"\n Preço: {this.Price}";
        }
    }
}