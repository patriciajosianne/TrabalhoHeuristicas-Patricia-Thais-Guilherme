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
        public List<Horario> HorariosAlocados { get; set; }
        public List<Professor> Professores { get; set; }

        public List<Alocacao> ListaTabu { get; set; }

        public QuadroHorario Quadro { get; set; }


        public ConstroiQuadroHorario()
        {
            Horarios = new List<Horario>();
            HorariosAlocados = new List<Horario>();
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
                    if(!HorariosAlocados.Contains(alocacao.Horario))
                        horarioMaisRestricoes = alocacao.Horario;
            }

            //escolhendo alocacao que possui professor com mais restricoes
            Alocacao melhorAlocacao = new Alocacao();
            foreach (Alocacao alocacao in Componentes)
            {
                if (alocacao.Horario == horarioMaisRestricoes)
                    if (melhorAlocacao.Professor.Restricoes.Count < alocacao.Professor.Restricoes.Count)
                        if(alocacao.Professor.HorariosAlocados.Count < 2)
                            melhorAlocacao = alocacao;
            }
            if (melhorAlocacao.Professor.Nome != null)
            {
                HorariosAlocados.Add(melhorAlocacao.Horario);
                melhorAlocacao.Professor.AddHorariosAlocados(melhorAlocacao.Horario);
                return (IComponente)melhorAlocacao;
            }
            else//Situação DeadLock
            {
                /*//busca horários não alocados ainda
                List<Horario> horariosNaoAlocados = new List<Horario>();
                foreach (Horario hor in Horarios)
                {
                    if (!HorariosAlocados.Contains(hor))
                        horariosNaoAlocados.Add(hor);
                }

                //busca professores não alocados
                List<Professor> professoresNaoAlocados = new List<Professor>();
                foreach (Professor prof in Professores)
                {
                    if (prof.HorariosAlocados.Count < 2)
                        professoresNaoAlocados.Add(prof);
                }

                //busco professores alocados que podem dar aula em horarios nao alocados
                List<Professor> professoresAlocadosSemRestricoes = new List<Professor>();
                foreach (Professor prof in Professores)
                {
                    foreach(Horario h in horariosNaoAlocados)
                    {
                        if ((prof.HorariosAlocados.Count == 2) && (!prof.Restricoes.Contains(h)))
                        {
                            professoresAlocadosSemRestricoes.Add(prof);                        
                        }                            
                    }
                }
                */


                /*
                 Implementar o deadlock em si, que fará as trocas
                 */

                //Busco professores alocados que dao aula em horarios que professores disponiveis podem dar
                /*foreach(Professor prof in professoresAlocadosSemRestricoes)
                {
                    foreach(Horario h in prof.HorariosAlocados)
                    {
                        foreach(Professor p in professoresNaoAlocados)
                        {
                            foreach(Horario hor in horariosNaoAlocados)
                            {
                                if(!ListaTabu.Contains(new Alocacao (p, h)))
                                {
                                    if((!p.Restricoes.Contains(h)) && (!prof.Restricoes.Contains(hor)))
                                    {

                                            prof.HorariosAlocados.Remove(h);
                                            prof.HorariosAlocados.Add(hor);
                                            p.AddHorariosAlocados(h);
                                            HorariosAlocados.Add(hor);
                                            Quadro.RemoveComponente(new Alocacao(prof,h));
                                            Quadro.AddComponente(new Alocacao(prof,hor));
                                            ListaTabu.Add(new Alocacao (p, h));
                                            return new Alocacao (p, h);
                                    }
                                }
                            }
                        }
                    }

                }*/

                //busca um horário não alocados ainda
                Horario horarioNaoAlocado = new Horario();
                foreach (Horario hor in Horarios)
                {
                    if (!HorariosAlocados.Contains(hor))
                    {
                        horarioNaoAlocado = hor;
                        break;
                    }
                }

                //busca professores não alocados
                List<Professor> professoresNaoAlocados = new List<Professor>();
                foreach (Professor prof in Professores)
                {
                    if (prof.HorariosAlocados.Count < 2)
                        professoresNaoAlocados.Add(prof);
                }



                foreach (Alocacao a in Quadro.Componentes)
                {
                    if (!a.Professor.Restricoes.Contains(horarioNaoAlocado))
                    {
                        foreach (Professor p in professoresNaoAlocados)
                        {
                            //incluir validacao de lista tabu
                            if ((!p.Restricoes.Contains(a.Horario))&&(p.HorariosAlocados.Count<2))
                            {
                                Alocacao aloc = new Alocacao();
                                aloc = a;
                                Quadro.RemoveComponente(aloc);
                                Quadro.AddComponente(new Alocacao(aloc.Professor, horarioNaoAlocado));
                                HorariosAlocados.Add(horarioNaoAlocado);
                                aloc.Professor.HorariosAlocados.Remove(aloc.Horario);
                                aloc.Professor.HorariosAlocados.Remove(horarioNaoAlocado);
                                p.AddHorariosAlocados(aloc.Horario);
                                return (new Alocacao(p, aloc.Horario));

                            }
                        }
                    }
                }
               
                return null;
            }
        }

        public override ISolucao CriaSolucaoVazia()
        {
            return Quadro;
        }

        public override bool VerificaSolucaoCompleta()
        {
            if (Quadro.Componentes.Count == 10)
                return true;

            return false;
        }
    }
}
