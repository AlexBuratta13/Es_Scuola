using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istruzione
{
    public class Studente
    {
        public List<Votazione> Votazioni { get; private set; }
        public string nome { get; private set; }
        public string cognome { get; private set; }
        public DateTime dataDiNascita { get; set; }
        public Studente(string nome,string cognome,DateTime dataDiNascita)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = dataDiNascita;
        }
        public void AddVoto(Votazione v)
        {
            Votazioni.Add(v);
        }
        public Votazione TrovaVotoMassimo()
        {
            Votazione max = Votazioni[0];
            for(int i = 0; i < Votazioni.Count; i++)
            {
                if(Votazioni[i].voto > max.voto)
                {
                    max = Votazioni[i];
                }
            }
            return max;
        }
        public Votazione TrovaVotoMinimo()
        {
            Votazione min = Votazioni[0];
            for (int i = 0; i < Votazioni.Count; i++)
            {
                if (Votazioni[i].voto < min.voto)
                {
                    min = Votazioni[i];
                }
            }
            return min;
        }
    }
}
