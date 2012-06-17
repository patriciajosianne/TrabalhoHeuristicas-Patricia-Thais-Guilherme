using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HeuristicaConstrutiva;

namespace ProblemaQuadroHorarios
{
    public class ConstroiQuadroHorario : HeuristicaConstrutiva.HeuristicaConstrutiva
    {

        public List<Horario> Horarios { get; set; }
        public List<Professor> Professores { get; set; }

        public List<Alocacao> ListaTabu { get; set; }

        public QuadroHorario Quadro { get; set; }


        public ConstroiQuadroHorario()
        {
            Horarios = new List<Horario>();
            Professores = new List<Professor>();
            ListaTabu = new List<Alocacao>();
            Quadro = new QuadroHorario();
        }

        public void AddRestricao(Professor p, Horario h)
        {
            p.Restricoes.Add(h);
            h.Restricoes.Add(p);

            p.Restricoes.Count();
            h.Restricoes.Count();
        }

        public override List<IComponente> GerarComponentes()
        {
            List<IComponente> componentes = new List<IComponente>();
            foreach(Horario hor in Horarios)
            {
                foreach (Professor prof in Professores)
                {
                    if((prof.HorariosAlocados.Count < 2) && (!prof.Restricoes.Contains(hor)) && (!ListaTabu.Contains(new Alocacao(prof, hor))))
                                componentes.Add((IComponente) new Alocacao(prof, hor));
                }
            }

            return componentes;
        }

        public override IComponente EscolheMelhorComponente(List<IComponente> Componentes)
        {
            //escolhendo horário com mais restrições
            Horario horarioMaisRestricoes = new Horario();
            foreach (Alocacao alocacao in Componentes)
            {
                if (horarioMaisRestricoes.Restricoes.Count < alocacao.Horario.Restricoes.Count)
                    horarioMaisRestricoes = alocacao.Horario;
            }

            //escolhendo alocacao que possui professor com mais restricoes
            Alocacao melhorAlocacao = new Alocacao();
            foreach (Alocacao alocacao in Componentes)
            {
                if (alocacao.Horario == horarioMaisRestricoes)
                    if (melhorAlocacao.Professor.Restricoes.Count < alocacao.Professor.Restricoes.Count)
                        melhorAlocacao = alocacao;
            }

            return (IComponente)melhorAlocacao;
        }

        public override ISolucao CriaSolucaoVazia()
        {
            return new QuadroHorario();
        }

        public override bool VerificaSolucaoCompleta()
        {
            if (Quadro.Componentes.Count == 10)
                return true;

            return false;
        }
    }
}
