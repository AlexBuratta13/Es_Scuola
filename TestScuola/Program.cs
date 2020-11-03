using Istruzione;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestScuola
{
    class Program
    {
        static void Main(string[] args)
        {
            Scuola scuola = new Scuola("Rosselli-Rasetti");
            Materia materia = scuola.CreateMateria("Religione");
            Classe classe = scuola.CreateClasse(4, "AI");
            Studente s = new Studente("alex", "buratta");
            Votazione max = scuola.TrovaVotoMassimo();
            Votazione min = scuola.TrovaVotoMinimo();
            classe.AddStudenti(s);
            Console.Write($"il voto massimo è{max.voto} Data:{max.data} materia:{max.Materia.nome}");
            Console.Write($"il voto minimo è{min.voto} Data:{min.data} materia:{min.Materia.nome}");
        }
    }
}
