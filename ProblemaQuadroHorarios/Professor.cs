using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemaQuadroHorarios
{
    public class Professor
    {
        public String Nome { get; set; }
        public List<Horario> Restricoes { get; set; }
        public List<Horario> HorariosAlocados { get; set; }

        public Professor()
        {
            Restricoes = new List<Horario>();
            HorariosAlocados = new List<Horario>();
        }

        public Professor(String name)
        {
            Restricoes = new List<Horario>();
            HorariosAlocados = new List<Horario>();
            this.Nome = name;
        }

        public void AddRestricao(Horario horario)
        {
            if (!Restricoes.Contains(horario))
                Restricoes.Add(horario);
        }

        public void RemoveRestricao(Horario horario)
        {
            if (Restricoes.Contains(horario))
                Restricoes.Remove(horario);
        }

        public void AddHorariosAlocados(Horario horario)
        {
            if (!HorariosAlocados.Contains(horario))
                HorariosAlocados.Add(horario);
        }

        public void RemoveHorariosAlocados(Horario horario)
        {
            if (HorariosAlocados.Contains(horario))
                HorariosAlocados.Remove(horario);
        }

    }
}
