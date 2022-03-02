using System;
using System.Collections.Generic;

namespace Models
{
    public class AgendamentoProcedimento
    {
        public static int ID = 0;
        private static List<AgendamentoProcedimento> AgendamentosProcedimentos = new List<AgendamentoProcedimento>();
        public int Id {get; set;}
        public int IdAgendamento {get; set;}
        public int IdProcedimento {get; set;}
        public Agendamento Agendamento { get; set; }
        public AgendamentoProcedimento(int IdAgendamento,
                                       int IdProcedimento)
                                       :this(++ID, IdAgendamento, IdProcedimento)
        {
        }

        private AgendamentoProcedimento(int Id,
                                        int IdAgendamento,
                                        int IdProcedimento)
        {
            this.Id = Id;
            this.IdAgendamento = IdAgendamento;
            this.IdProcedimento = IdProcedimento;

            AgendamentosProcedimentos.Add(this);
        }

        public static List<AgendamentoProcedimento> GetAgendamentoProcedimentos()
        {
            return AgendamentosProcedimentos;
        }

        public static void RemoverAgendamentoProcedimento(AgendamentoProcedimento agendamentoProcedimento)
        {
            AgendamentosProcedimentos.Remove(agendamentoProcedimento);
        }

        public override bool Equals(object o)
        {
            if(o == null)
            {
                return false;
            }

            if(!AgendamentoProcedimento.ReferenceEquals(o, this))
            {
                return false;
            }

            AgendamentoProcedimento ap = (AgendamentoProcedimento) o;
            return ap.Id == this.Id;

        }


        public override string ToString()
        {
            return $"\n ---------------------------------------" +
                   $"\n Id: {this.Id}" + 
                   $"\n Id Agendamento: {this.IdAgendamento}" +
                   $"\n Id Procedimento: {this.IdProcedimento}";
        }
    }
}