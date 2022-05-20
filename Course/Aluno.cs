using System;
using System.Globalization;

namespace Course {
    class Aluno {
        public double Nota1, Nota2, Nota3;
        public double NotaFinal;
        public double QtdFaltante;
        public string Nome;
        public string VerificarAprovacao() {
            if(NotaFinal >= 60) {
                return "APROVADO";
            }
            else {
                QtdFaltante = 60 - NotaFinal;
                return $"REPROVADO\nFALTARAM {QtdFaltante.ToString("F2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }

        public string CalcularNotas() {
            NotaFinal = Nota1 + Nota2 + Nota3;
            return $"NOTA FINAL = {NotaFinal}";
        }

        public override string ToString() {
            return $"{CalcularNotas()} \n{VerificarAprovacao()}";
        }

    }
}
