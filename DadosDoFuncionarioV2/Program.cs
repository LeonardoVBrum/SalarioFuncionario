using System.Globalization;
namespace DadosDoFuncionarioV2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcioanrio pessoa = new Funcioanrio();

            Console.WriteLine("Digite os dados do funcionário: !");
            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            pessoa.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            pessoa.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Deseja aumentar o salário em quantos %: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.AumentarSalario(porcent);

            Console.WriteLine($"Salario final= {pessoa} ");
        }
    }

}   
