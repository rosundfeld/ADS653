using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Pessoa
    {
        private string nome;
        private int idade;
        private const int MAX = 10;
        private long identidade;
        private string profissao;
        private int qtdd = 0;
        private Animal[] pet = new Animal[10];

        public string Falar()
        {
            return nome + " falou algo muito topzera";
        }
        public void trabalhar(int horas)
        {
            Console.WriteLine(nome + " Trabalhou " + horas + ". Nossa esse cara eh muito trabalhador");
        }
        public void comer()
        {
            Console.WriteLine(nome + " Nhom nhom nhom nhom nhom");
        }

        public void add(Animal bicho)
        {
            if (pet[MAX].Nome == null)
            {
                pet[qtdd] = bicho;
                qtdd++;
            }
            else
            {
                Console.WriteLine("Vc já tem muitos animais >:c");
            }
        }

        public void remove(Animal bicho)
        {
            for (int i = 0; i < qtdd; i++)
            {
                if (pet[i].Nome == bicho.Nome)
                {

                }

            }
        }

        public void SizeOf()
        {

        }

        public void get()
        {

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

        public int Idade
        {
            get
            {
                return idade;
            }

            set
            {
                idade = value;
            }
        }

        public long Identidade
        {
            get
            {
                return identidade;
            }

            set
            {
                identidade = value;
            }
        }

        public string Profissao
        {
            get
            {
                return profissao;
            }

            set
            {
                profissao = value;
            }
        }


        internal Animal[] Pet
        {
            get
            {
                return pet;
            }

            set
            {
                pet = value;
            }
        }

        public int Qtdd
        {
            get
            {
                return qtdd;
            }

            set
            {
                qtdd = value;
            }
        }
    }
}
