using System;
using System.Linq;
using System.Collections.Generic;
using Models;

namespace Controllers
{
    public class EspecialidadeController
    {
        public static Especialidade InsertEspecialidade(string Desc, string Detail)
        {
            if(String.IsNullOrEmpty(Desc))
            {
                throw new Exception ("Descrição invalida");
            }
            if(String.IsNullOrEmpty(Detail))
            {
                throw new Exception ("Detalhes invalidos");
            }
            return new Especialidade(Desc, Detail);
        }

        public static Especialidade UpdateEspecialidade(int Id, string Desc, string Detail)
        {
            Especialidade especialidade = GetEspecialidade(Id);
            if(!String.IsNullOrEmpty(Desc))
            {
                especialidade.Desc = Desc;
            }
            if(!String.IsNullOrEmpty(Detail))
            {
                especialidade.Detail = Detail;
            }

            return especialidade;
        }

        public static Especialidade DeleteEspecialidade(int Id)
        {
            Especialidade especialidade = GetEspecialidade(Id);
            Especialidade.RemoverEspecialidade(especialidade);
            return especialidade;
        }

        public static List<Especialidade> SelectEspecialidade()
        {
            return Especialidade.GetEspecialidades();
        }

        public static Especialidade GetEspecialidade(int Id)
        {
            Especialidade especialidade = (
                from Especialidade in Especialidade.GetEspecialidades()
                where Especialidade.Id == Id
                select Especialidade
            ).First();

            if(especialidade == null)
            {
                throw new Exception("Especialidade não encontrada");
            }

            return especialidade;
        } 
    }
}