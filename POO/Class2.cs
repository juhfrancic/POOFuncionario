/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public double Altura { get; set; }
        public string Sobrenome { get; set; }

        public Pessoa()
        {

        }

        public void setIdade(int idade)
        {
            this.Idade = idade;
        }

        public int getIdade()
        {
            return this.Idade;
        }

        public void setNome(string nome)
        {
            this.Nome = nome;
        }

        public string getNome()
        {
            return this.Nome;
        }

        public void setSexo(string sexo)
        {
            this.Sexo = sexo;
        }

        public string getSexo()
        {
            return this.Sexo;
        }
        public void setAltura(double altura)
        {
            this.Altura = altura;
        }

        public double getAltura()
        {
            return this.Altura;
        }
        public void setSobrenome(string sobrenome)
        {
            this.Sobrenome = sobrenome;
        }

        public string getSobrenome()
        {
            return this.Sobrenome;
        }


    public void ExibirInfo()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Sobrenome: " + this.Sobrenome);
            Console.WriteLine("Idade: " + this.Idade);
            Console.WriteLine("Sexo: " + this.Sexo);
            Console.WriteLine("Altura: " + this.Altura);
            this.Address.showInfo();
        } 
    }

}
