using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istruzione
{
    public class Classe
    {
        public int anno { get; private set;}
        public string sezione { get; private set;}
        public List<Studente> Studenti { get; private set; } = new List<Studente>();
        public Classe(int anno,string sezione)
        {
            this.anno = anno;
            this.sezione = sezione;
        }
        public string GetNome
        {
            get
            {
                return sezione + anno;
            }
        }
        public void AddStudenti(Studente s)
        {
            Studenti.Add(s); 
        }
        public Votazione TrovaVotoMassimo()
        {
            Votazione max = Studenti[0].TrovaVotoMassimo();
            foreach(Studente s in Studenti)
            {
                Votazione v = s.TrovaVotoMassimo();
                if(v.voto > max.voto)
                {
                    max = v;
                }
            }
            return max;
        }
        public Votazione TrovaVotoMinimo()
        {
            Votazione min = Studenti[0].TrovaVotoMinimo();
            foreach (Studente s in Studenti)
            {
                Votazione v = s.TrovaVotoMinimo();
                if (v.voto < min.voto)
                {
                    min = v;
                }
            }
            return min;
        }
    }
}
