using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istruzione
{
    public class Scuola
    {
        List <Classe> classi = new List<Classe>();
        List <Materia> materie = new List<Materia>();
        public string nome { get; private set;}
        public Scuola(string nome)
        {
            this.nome = nome;
        }
        public string GetNome()
        {
            return nome;
        }
        public Materia CreateMateria(string nome)
        {
            Materia m = new Materia(nome);
            materie.Add(m);
            return m;
        }
        public Classe CreateClasse(int anno,string sezione)
        {
            Classe c = new Classe(anno, sezione);
            classi.Add(c);
            return c;
        }
        public Votazione TrovaVotoMassimo()
        {
            Votazione max = classi[0].TrovaVotoMassimo();
            foreach (Classe c in classi)
            {
                Votazione v = c.TrovaVotoMassimo();
                if (v.voto > max.voto)
                {
                    max = v;
                }
            }
            return max;
        }
        public Votazione TrovaVotoMinimo()
        {
            Votazione min = classi[0].TrovaVotoMinimo();
            foreach (Classe c in classi)
            {
                Votazione v = c.TrovaVotoMinimo();
                if (v.voto < min.voto)
                {
                    min = v;
                }
            }
            return min;
        }
    }
}
