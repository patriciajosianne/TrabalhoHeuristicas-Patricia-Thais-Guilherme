using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using HeuristicaConstrutiva;

namespace ProblemaQuadroHorarios
{
    public class QuadroHorario : ISolucao
    {

        public List<IComponente> Componentes
        {
            get;
            set;
        }

        public float Avaliacao
        {
            get { throw new NotImplementedException(); }
        }

        public QuadroHorario()
        {
            Componentes = new List<IComponente>();
        }

        public void AddComponente(IComponente Componente)
        {
            if (!Componentes.Contains(Componente))
                Componentes.Add(Componente);
        }

        public void RemoveComponente(IComponente Componente)
        {
            if (Componentes.Contains(Componente))
                Componentes.Remove(Componente);               
        }

    }
}
