using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istruzione
{
    public class Scuola
    {
        public string nome { get; private set;}
        public Scuola(string nome)
        {
            this.nome = nome;
            Classi = new List<Classe>();
        }
    }
}
