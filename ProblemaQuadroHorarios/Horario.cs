using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemaQuadroHorarios
{
    public class Horario
    {
        public String Id { get; set; }
        public bool Disponivel { get; set; }
        public List<Professor> Restricoes { get; set; }

        public Horario()
        {
            Restricoes = new List<Professor>();
            Disponivel = true;
        }
        
        public Horario(String id)
        {
            Restricoes = new List<Professor>();
            Disponivel = true;
            Id = id;
        }

        public void AddRestricao(Professor professor)
        {
            if (!Restricoes.Contains(professor))
                Restricoes.Add(professor);
        }

        public void RemoveRestricao(Professor professor)
        {
            if (Restricoes.Contains(professor))
                Restricoes.Remove(professor);
        }
    }
}
