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

            Funcionario junior = new VendedorJunior();
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
            Console.WriteLine(gerente);
        }
    }
}
