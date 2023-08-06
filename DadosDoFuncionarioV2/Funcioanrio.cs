using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace DadosDoFuncionarioV2
{
    internal class Funcioanrio
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalaioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
                   +", $"
                   + SalaioLiquido().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}
