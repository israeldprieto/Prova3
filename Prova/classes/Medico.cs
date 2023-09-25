using System;
namespace Prova.classes
{
    internal class Medico: Funcionario
    {
        public string CRM { get; set; }
        public string Especialidade { get; set; }
        public double Valorhoraextra { get; set; }
        
        public Medico ()
        {

        }
        public Medico(string nome, string cpf, string matricula, DateTime dataN,string sexo, double salario, string cRM, string especialidade, double valorhoraextra) :
            base(nome, cpf, matricula, dataN, sexo, salario)
        {
            CRM = cRM;
            Especialidade = especialidade;
            Valorhoraextra = valorhoraextra;
        }
        public double CalcularAuxilio()
        {
            return Salario * 0.2;
        }
    }
}
