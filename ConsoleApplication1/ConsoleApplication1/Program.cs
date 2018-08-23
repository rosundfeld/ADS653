using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            p1.Nome = "Vetulio Gargas";
            p1.Idade = 62;
            p1.Identidade = 8245764634;
            p1.Profissao = "Ditador";
            a1.Nome = "Lagarto";
            a1.Apelido = "Toni";
            a1.Selvagem = true;
            a1.Dono = p1;

        }
    }
}
