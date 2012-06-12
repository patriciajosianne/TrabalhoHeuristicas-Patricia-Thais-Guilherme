using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HeuristicaConstrutiva;

namespace SolucaoQuadroHorario
{
    public class QuadroHorario : ISolucao
    {
        int IdHorario { get; set; }
        String DescHorario { get; set; }
        int QtdeRestricoes { get; set; }
        Boolean Disponivel { get; set; }
        int Professor { get; set; }

        public QuadroHorario()
        {
            QtdeRestricoes = 0;
            Disponivel = true;
            Professor = 0;
        }

    }
}
