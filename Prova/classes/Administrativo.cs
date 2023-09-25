using System;
namespace Prova.classes
{
    internal class Administrativo : Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo(string funcao,string nome, string cpf, string matricula, DateOnly dateOnly)
            
        {
            Funcao = funcao;
        }
        public void CalcularSalario()
        {

        }

    }
}
