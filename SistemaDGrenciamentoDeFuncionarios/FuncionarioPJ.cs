using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDGrenciamentoDeFuncionarios
{
    internal class FuncionarioPJ : Funcionario
    {
        private int HorasTrabalhadas;
        private double ValorHora;

        public void SetHorasTrabalhadas(int horas)
        {
            this.HorasTrabalhadas = horas;
        }
        public int GetHorasTrabalhadas(int horas)
        {
            return this.HorasTrabalhadas;
        }
        public void SetValorHora(double valor)
        {
            this.ValorHora = valor;
        }
        public double GetValorHora(double valor)
        {
            return this.ValorHora;
        }
        public override double CalcularSalarioFinal()
        {
            return this.HorasTrabalhadas * this.ValorHora;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine("Horas trabalhadas: " + this.HorasTrabalhadas);
            Console.WriteLine("Valor hora: " + this.ValorHora);
            Console.WriteLine("Salario final: " + this.CalcularSalarioFinal());
        }
    }
}
