/*// See https://aka.ms/new-console-template for more information
using POO;


#region VetorPessoa
Pessoa[] pessoas = new Pessoa[3];


for (int i = 0; i < pessoas.Length; i++)
{
    pessoas[i] = new Pessoa();

    Console.WriteLine($"Digite o nome{i + 1}: ");
    pessoas[i].setNome(Console.ReadLine());

    Console.WriteLine($"Digite o sexo{i + 1}: ");
    pessoas[i].setSexo(Console.ReadLine());

    Console.WriteLine($"Digite a altura{i + 1}: ");
    pessoas[i].setAltura(Convert.ToDouble(Console.ReadLine()));

    Console.WriteLine($"Digite o sobrenome{i + 1}: ");
    pessoas[i].setSobrenome(Console.ReadLine());

    Console.WriteLine($"Digite a idade{i + 1}: ");
    pessoas[i].setIdade(Convert.ToInt16(Console.ReadLine()));
}

for(int i = 0; i < pessoas.Length; i++)
{
    pessoas[i].ExibirInfo();
    Console.WriteLine();
}
#endregion

Pessoa[] pessoas = new Pessoa();


pessoas.Address = new Address(
    "Rua A", 123, "Bairro B",
    "12345-678", null, "cidade B", "Estado D", "Pais E");*/

