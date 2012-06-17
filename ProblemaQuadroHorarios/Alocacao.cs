using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HeuristicaConstrutiva;

namespace ProblemaQuadroHorarios
{
    public class Alocacao : IComponente
    {

        public Professor Professor { get; set; }
        public Horario Horario { get; set; }

        public Alocacao()
        {
            Professor = new Professor();
            Horario = new Horario();
        }

        public Alocacao(Professor prof, Horario horario)
        {
            Professor = prof;
            Horario = horario;
        }
        
        //verificar se vai precisar
        public object Valor
        {
            get { throw new NotImplementedException(); }
        }

        
    }
}
