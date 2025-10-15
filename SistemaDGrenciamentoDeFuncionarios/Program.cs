// See https://aka.ms/new-console-template for more information
using SistemaDGrenciamentoDeFuncionarios;

Funcionario[] funcionarios;

Console.WriteLine("Informe quantos funcionarios quer cadastrar: ");
int qtdFuncionarios = int.Parse(Console.ReadLine());

funcionarios = new Funcionario[qtdFuncionarios];

void PreencheVetor(Funcionario[] funcionarios, int qtdFuncionarios)
{
    for (int i = 0; i < qtdFuncionarios; i++)
    {
        bool objetoCriado = false;
        do
        {
            Console.WriteLine("Digite tipo de funcionario: (CLT/PJ)");
            string tipoFuncionario = Console.ReadLine();

            if (tipoFuncionario == "CLT")
            {
                funcionarios[i] = new FuncionarioCLT();
                objetoCriado = true;
            }
            else if (tipoFuncionario == "PJ")
            {
                funcionarios[i] = new FuncionarioPJ();
                objetoCriado = true;
            }
            else
            {
                Console.WriteLine("Tipo ivalido, digite novamente: (CLT/PJ)");
            }
        } while (objetoCriado == false);
        Console.WriteLine("Digite o nome do funcionário: ");
        funcionarios[i].SetNome(Console.ReadLine());
        Console.WriteLine("Digite o salario base: ");
        funcionarios[i].SetSalarioBase(Convert.ToDouble(Console.ReadLine()));

        if (funcionarios[i] is FuncionarioCLT clt)
        {
            Console.WriteLine("Digite o bonus: ");
            clt.SetBonus(Convert.ToDouble(Console.ReadLine()));

        }else if (funcionarios[i] is FuncionarioPJ pj)
        {
            Console.WriteLine("Digite as horas trabalhadas: ");
            pj.SetHorasTrabalhadas(int.Parse(Console.ReadLine()));
            Console.WriteLine("Valor hora: ");
            pj.SetValorHora(Convert.ToDouble(Console.ReadLine()));
        }
    }
  
}

void ExibirFuncionarios(Funcionario[] funcionarios)
{
    for(int i = 0; i < funcionarios.Length; i++)
    {
        Console.WriteLine($"\nFuncionario {i + 1}:");

        funcionarios[i].ExibirInfo();
        Console.WriteLine($"Salário final: {funcionarios[i].CalcularSalarioFinal()}");
    }
}

PreencheVetor(funcionarios, qtdFuncionarios);
ExibirFuncionarios(funcionarios);
