using System;
using System.Globalization;

namespace Course {
    class Funcionario {
        public string Nome;
        public double SalarioBruto;
        public double Imposto = 1000;


        public double SalarioLiquido() {
            double salarioLiquido = SalarioBruto - Imposto; 
            return salarioLiquido;
        }

        public void AumentarSalario(double porcentagemAumento) {

            double salarioAumentado = SalarioLiquido() + ((porcentagemAumento / 100) * SalarioLiquido());
            Console.WriteLine(porcentagemAumento);
            Console.WriteLine(SalarioLiquido());
            Console.WriteLine($"Dados atualizados: {Nome}, R${salarioAumentado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
        public override string ToString() {
            return $"\nNome: {Nome} \nSalário: R${SalarioBruto}";
        }
    }
}
