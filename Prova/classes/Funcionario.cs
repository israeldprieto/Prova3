using System;
namespace Prova.classes
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public DateTime DataN { get; set; }
        public string Sexo { get; set; }         
        public double Salario { get; set; }

        public Funcionario()
        {

        }
        public Funcionario(string nome, string cPF, string matricula, DateTime dataN, string sexo, double salario)
        {
            Nome = nome;
            CPF = cPF;
            Matricula = matricula;
            DataN = DataN; 
            Sexo = sexo;
            Salario = salario;
        }

    }
}
