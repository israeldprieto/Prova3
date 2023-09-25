using Prova.classes;

public class Program
{
    static void Main(string[] args)
    {
        List<Funcionario>funcionarios = new List<Funcionario>();
        Funcionario a = new Funcionario();

        while(true)
        {
            Console.WriteLine("Selecione a opção desejada");
            Console.WriteLine("0-Funcionário");
            Console.WriteLine("1-Médico");
            Console.WriteLine("2-Funcionário Administrativo");
            Console.Write("Opção escolhida: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o nome do funcionário:");
            string nome = Console.ReadLine();
            Console.Write("Digite o cpf do funcionário: ");
            string cpf = Console.ReadLine();
            Console.Write("Digite a matrícula do funcionário: ");
            string Matricula = Console.ReadLine();
            Console.Write("Digite a data de nascimento do funcionário: ");
            DateTime Datan = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Digite o sexo do funcionário: ");
            string Sexo = Console.ReadLine();
            Console.Write("Digite o salário do funcionário: ");
            double Salario = Convert.ToDouble(Console.ReadLine());
            
            if (opcao == 0)
            {
                Funcionario funcionario = new Funcionario();
                funcionarios.Add(funcionario);
            }
            else if(opcao == 1)
            {
                Console.Write("CRM: ");
                string crm = Console.ReadLine();
                Console.Write("Valor de Hora Extra: ");
                double Horaextra = Convert.ToDouble(Console.ReadLine());
                Console.Write("Especialidade: ");
                string especialidade = Console.ReadLine();

                Medico medico = new Medico(nome, cpf, Matricula, Datan, Sexo, Salario, crm, especialidade, Horaextra);
                funcionarios.Add(medico);
            }
            else if(opcao == 2)
            {
                Console.Write("Função: ");
                string funcao = Console.ReadLine();

                //Administrativo admin = new Administrativo(nome, cpf, Matricula, Datan, Sexo, Salario, funcao);
                //funcionarios.Add(admin);
                    
            }
        }
        
        
        
        
    }
}

