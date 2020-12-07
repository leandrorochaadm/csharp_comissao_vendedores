using Leandro_atividade2.RegraDeNegocio;
using System;


namespace Leandro_atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            //comissao
            //% pra atingir meta
            //salario final
            int opcao = int.MaxValue;
            do
            {
                Console.WriteLine(">> Dados do funcionário <<\n");
                Console.Write("CPF: ");
                string cpf = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = Convert.ToDouble(Console.ReadLine());

                Console.Write("Meta De Vendas: ");
                double metaDeVendas = Convert.ToDouble(Console.ReadLine());

                Console.Write("Total das Vendas: ");
                double totalVendas = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Escolha um cargo: \n1-Vendedor\n2-Supervisor\n3-Gerente\n0-Para Sair");
                
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1: EscolhaVendedor(cpf, totalVendas, salario, metaDeVendas);
                        break;
                    case 2: EscolhaLideranca(cpf, totalVendas, salario, metaDeVendas, opcao);
                        break;
                    case 3: EscolhaLideranca(cpf, totalVendas, salario, metaDeVendas, opcao);
                        break;
                    default: opcao = int.MaxValue;
                        break;
                }


            } while (opcao==0);

            void EscolhaVendedor(string cpf, double totalVendas, double salario, double metaDeVendas) 
            {
                Console.WriteLine("Quantos anos o(a) vendedor(a) tem de empresa?");
                int tempoEmpresa = Convert.ToInt32(Console.ReadLine());
                if (tempoEmpresa <= 3) 
                {
                    Funcionario junior = new VendedorJunior();
                    junior.Cpf = cpf;
                    junior.TotalVendas = totalVendas;
                    junior.Salario = salario;
                    junior.MetaDeVendas = metaDeVendas;
                    junior.CalcularSalarioFinal();
                    Console.WriteLine($"Vendedor junior: {junior}");
                }
                else if (tempoEmpresa > 3 && tempoEmpresa <= 7) 
                {
                    Funcionario padrao = new VendedorPadrao();
                    padrao.Cpf = cpf;
                    padrao.TotalVendas = totalVendas;
                    padrao.Salario = salario;
                    padrao.MetaDeVendas = metaDeVendas;
                    padrao.CalcularSalarioFinal();
                    Console.WriteLine($"Vendedor padrão-> {padrao}");
                }
                else if (tempoEmpresa>7) 
                {
                    Funcionario master = new VendedorMaster();
                    master.Cpf = cpf;
                    master.TotalVendas = totalVendas;
                    master.Salario = salario;
                    master.MetaDeVendas = metaDeVendas;
                    master.CalcularSalarioFinal();
                    Console.WriteLine($"Vendedor master-> {master}");
                }
            }

            void EscolhaLideranca(string cpf, double totalVendas, double salario, double metaDeVendas, int opcao )
            {
                Console.Write("Total Vendas da Concessionária: ");
                double totalVendasConc = Convert.ToDouble(Console.ReadLine());
                
                Console.Write("Metas De Vendas da Concessionária: ");
                double metasDeVendasConc = Convert.ToDouble(Console.ReadLine());

                if (opcao == 2) 
                {
                    SupervisorDeVendas supervisor = new SupervisorDeVendas();
                    supervisor.Cpf = cpf;
                    supervisor.TotalVendas = totalVendas;
                    supervisor.Salario = salario;
                    supervisor.MetaDeVendas = metaDeVendas;
                    supervisor.MetasDeVendasConc = metasDeVendasConc;
                    supervisor.TotalVendasConc = totalVendasConc;
                    supervisor.CalcularSalarioFinal();
                    Console.WriteLine($"Supervisor-> {supervisor}");
                } else
                {
                    Gerente gerente = new Gerente();
                    gerente.Cpf = cpf;
                    gerente.TotalVendas = totalVendas;
                    gerente.Salario = salario;
                    gerente.MetaDeVendas = metaDeVendas;
                    gerente.MetasDeVendasConc = metasDeVendasConc;
                    gerente.TotalVendasConc = totalVendasConc;
                    gerente.CalcularSalarioFinal();
                    Console.WriteLine($"Gerente-> {gerente}");

                }


            }

            /*Funcionario junior = new VendedorJunior();
            junior.Cpf = "10760979014";
            junior.TotalVendas = 115121;
            junior.Salario = 3000;
            junior.MetaDeVendas = 30000;
            junior.CalcularSalarioFinal();
            Console.WriteLine(junior);

            Funcionario master = new VendedorMaster();
            master.Cpf = "90273698010";
            master.TotalVendas = 205414;
            master.Salario = 7000;
            master.MetaDeVendas = 70000;
            master.CalcularSalarioFinal();
            Console.WriteLine(master);

            Funcionario padrao = new VendedorPadrao();
            padrao.Cpf = "67127361029";
            padrao.TotalVendas = 263458;
            padrao.Salario = 5000 ;
            padrao.MetaDeVendas = 50000;
            padrao.CalcularSalarioFinal();
            Console.WriteLine(padrao);


            SupervisorDeVendas supervisor = new SupervisorDeVendas();
            supervisor.Cpf = "10230417078";
            supervisor.TotalVendas = 105241;
            supervisor.Salario = 8000;
            supervisor.MetaDeVendas = 10000;
            supervisor.TotalVendasConc = junior.TotalVendas + master.TotalVendas + padrao.TotalVendas + supervisor.TotalVendas + 105000;
            supervisor.MetasDeVendasConc = junior.MetaDeVendas + master.MetaDeVendas + padrao.MetaDeVendas + supervisor.MetaDeVendas + 10000;
            supervisor.CalcularSalarioFinal();
            Console.WriteLine(supervisor);

            Gerente gerente = new Gerente();
            gerente.Cpf = "66035702031";
            gerente.TotalVendas = 105000;
            gerente.Salario = 10000;
            gerente.MetaDeVendas = 10000;
            gerente.TotalVendasConc = junior.TotalVendas+master.TotalVendas+padrao.TotalVendas+supervisor.TotalVendas+gerente.TotalVendas;
            gerente.MetasDeVendasConc = junior.MetaDeVendas + master.MetaDeVendas + padrao.MetaDeVendas + supervisor.MetaDeVendas + gerente.MetaDeVendas; ;
            gerente.CalcularSalarioFinal();
            Console.WriteLine(gerente);*/
        }
    }
}
