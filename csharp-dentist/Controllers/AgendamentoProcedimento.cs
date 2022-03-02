using System;
using Models;
using System.Collections.Generic;
using System.Linq;

namespace Controllers
{
    public class AgendamentoProcedimentoControllers
    {
        public static AgendamentoProcedimento InsertAgendamentoProcedimento(int IdAgendamento,
                                                                            int IdProcedimento)
        {
            AgendamentoControllers.getAgendamento(IdAgendamento);
            ProcedimentoControllers.GetProcedimento(IdProcedimento);
            return new AgendamentoProcedimento(IdAgendamento, IdProcedimento);
        }

        public static AgendamentoProcedimento UpdateAgendamentoProcedimento(int Id,
                                                                            int IdAgendamento,
                                                                            int IdProcedimento)
        {
            AgendamentoProcedimento agendamentoProcedimento = GetAgendamentoProcedimento(Id);
            AgendamentoControllers.GetAgendamento(IdAgendamento);
            ProcedimentoControllers.GetProcedimento(IdProcedimento);

            agendamentoProcedimento.IdAgendamento = IdAgendamento;
            agendamentoProcedimento.IdProcedimento = IdProcedimento;

            return agendamentoProcedimento;
        }

        public static List<AgendamentoProcedimento> VisualizarAgendamentoProcedimento()
        {
            return AgendamentoProcedimento.GetAgendamentoProcedimentos();
        }

        public static AgendamentoProcedimento DeleteAgendamentoProcedimento(int Id)
        {
            AgendamentoProcedimento agendamentoProcedimento = GetAgendamentoProcedimento(Id);
            AgendamentoProcedimento.RemoverAgendamentoProcedimento(agendamentoProcedimento);
            return agendamentoProcedimento;
        }

        public static AgendamentoProcedimento GetAgendamentoProcedimento(int Id)
        {
            AgendamentoProcedimento agendamentoProcedimento = (
                            from AgendamentoProcedimento in AgendamentoProcedimento.GetAgendamentoProcedimentos()
                                where AgendamentoProcedimento.Id == Id
                                select AgendamentoProcedimento
                        ).First();

            if (agendamentoProcedimento == null)
            {
                throw new Exception("Campo(s) agendamento e/ou procedimento não encontrado!");
            }

            return agendamentoProcedimento;
        }
    }
}