using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDGrenciamentoDeFuncionarios
{
    public class FuncionarioCLT : Funcionario
    {
        private double Bonus;
        public override double CalcularSalarioFinal()
        {
            return this.GetSalarioBase() + this.Bonus;
        }

        public void SetBonus(double bonus)
        {
            this.Bonus = bonus;
        }
        public double GetBonus(double bonus)
        {
            return this.Bonus;
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine("Bonus: " + this.Bonus);
            Console.WriteLine("Salario Total: " + this.CalcularSalarioFinal());
        }
    }
}
