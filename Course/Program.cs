using System;
using System.Globalization;

namespace Course {
    class Program {

        static string VerificaIdade(Pessoa pessoa1, Pessoa pessoa2) {
            if (pessoa1.idade > pessoa2.idade) {
                return $"{pessoa1.nome}";
            }
            else {
                return $"{pessoa2.nome}";
            }
        }

        static double CalculaMedia(double x, double y) {
            return (x + y) / 2;
        }

        /* Exercicio sobre Inicial de POO*/
        static void Exercicio1() {
            Pessoa pessoa1;
            Pessoa pessoa2;

            string retorno = "";

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            pessoa1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            pessoa2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.idade = Convert.ToInt32(Console.ReadLine());

            retorno = VerificaIdade(pessoa1, pessoa2);


            Console.WriteLine($"Pessoa mais velha: {retorno}");
        }

        /* Exercicio sobre Membros Estáticos*/
        static void Exercicio2() {
            Funcionario funcionario;
            funcionario = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario.SalarioBruto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            funcionario.AumentarSalario(Convert.ToDouble(Console.ReadLine()));

        }

        /* Exercicio sobre Membros Estáticos*/
        static void Exercicio3() {
            Aluno aluno;

            aluno = new Aluno();
            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Write("Digite as três notas do aluno: ");
            aluno.Nota1 = Convert.ToDouble(Console.ReadLine());
            aluno.Nota2 = Convert.ToDouble(Console.ReadLine());
            aluno.Nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(aluno);
        }
        /* Exercicio sobre Membros Estáticos*/
        static void Exercicio4() {
            Console.Write("Qual é a cotação do dólar?");
            double cotacaoDolar = double.Parse(Console.ReadLine());
            Console.Write("Quantos dólares você vai comprar?");
            double valorDolar = double.Parse(Console.ReadLine());
            double resultado = ConversorDeMoeda.ConversaoParaReais(cotacaoDolar, valorDolar);


            Console.WriteLine($"Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }

        static void ExercicioMatriz() {
            int l, c;
            l = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            int[,] mat = new int[l,c];


            for (int i = 0; i < l; i++) {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    if(mat[i,j] == x) {
                        if(j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if(i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if(j < c - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < l - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }

            Console.WriteLine("Matrix: ");
            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine("");
            }
        }

        static void Main(string[] args) {
            //Exercicio1();
            //Exercicio2();
            //Exercicio3();
            //Exercicio4();
            ExercicioMatriz();
        }
    }
}
