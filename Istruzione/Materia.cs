using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istruzione
{
    public class Materia
    {
        public string nome { get; private set; }
        public Materia(string nome)
        {
            this.nome = nome;
        }
    }
}
