using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal
    {
        private string nome;
        private string apelido;
        private bool selvagem;
        private Pessoa dono;

        public string comunicar()
        {
            return nome + "Au au au au";
        }

        public void brincar()
        {
            Console.WriteLine(nome + "está traficando drogas na biqueira do José");
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Apelido
        {
            get
            {
                return apelido;
            }

            set
            {
                apelido = value;
            }
        }

        public bool Selvagem
        {
            get
            {
                return selvagem;
            }

            set
            {
                selvagem = value;
            }
        }

        internal Pessoa Dono
        {
            get
            {
                return dono;
            }

            set
            {
                dono = value;
            }
        }
    }
}
