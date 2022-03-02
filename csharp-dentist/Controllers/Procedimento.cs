using System;
using System.Linq;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class ProcedimentoControllers
    {
        public static Procedimento InsertProcedimento(string Desc, double Price)
        {

            if(String.IsNullOrEmpty(Desc))
            {
                throw new Exception("Descrição inválida");
            }
            return new Procedimento(Desc, Price);
        }

        public static Procedimento UpdateProcediemto(int Id, string Desc, double Price)
        {
            Procedimento procedimento = GetProcedimento(Id);
            if(String.IsNullOrEmpty(Desc))
            {
                procedimento.Desc = Desc;
            }
            return procedimento;
        }

         public static List<Procedimento> SelectProcedimento()
        {
            return Procedimento.GetProcedimentos();
        }

        public static Procedimento GetProcedimento(int Id)
        {
            Procedimento procedimento = (
                from Procedimento in Procedimento.GetProcedimentos()
                where Procedimento.Id == Id
                select Procedimento
            ).First();
            if(procedimento == null)
            {
                throw new Exception("Procedimento não encontrado");
            }
            return procedimento;
        }
    }
}