using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDGrenciamentoDeFuncionarios
{
    public abstract class Funcionario //Absract torna a classe nao instanciavel, classe de producao de classes nao de objetos
    {
        private string Nome;
        private double SalarioBase;

        public abstract double CalcularSalarioFinal();

        public virtual void ExibirInfo()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Salario Base: " + this.SalarioBase);
        }

        public void SetNome(string nome)
        {
            this.Nome = nome;
        }

        public string GetNome(string nome)
        {
            return this.Nome;
        }

        public void SetSalarioBase(double salarioBase) {
            this.SalarioBase = salarioBase;
        }

        public double GetSalarioBase()
        {
            return this.SalarioBase;
        }
    }

}
