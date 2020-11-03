using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istruzione
{
    public class Votazione
    {
        public double voto;
        public DateTime data;
        private Studente studente;
        public Materia Materia { get; private set; }
        public Votazione(double voto, Studente s ,Materia m)
        {
            this.voto = voto;
            studente = s;
            Materia = m;
            data = DateTime.Now;
        }
        public bool IsSufficiente()
        {
            return voto >= 6;
        }
    }
}