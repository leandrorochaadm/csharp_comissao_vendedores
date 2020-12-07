using System;
using System.Collections.Generic;
using System.Text;

namespace Leandro_atividade2.RegraDeNegocio
{
    abstract class Funcionario
    {
        public string Cpf { get; set; }
        public double Salario { get; set; }
        public double TotalVendas { get; set; }
        public double MetaDeVendas { get; set; }
        public double SalarioFinal { get; set; }
   
        public double Bonificacao() 
        {
            return TotalVendas*0.02;
        }
        public abstract double ComissaoDasVendas();

        public void CalcularSalarioFinal() 
        {
            if (TotalVendas >= (MetaDeVendas * 0.65))
            {
                SalarioFinal = Salario + ComissaoDasVendas();
            } else
            SalarioFinal =  Salario;
        }

        private double QuantoFaltaMeta()
        {
            return (1 - (TotalVendas/MetaDeVendas))*100;
        }
        public override string ToString() => $"CPF: {Cpf} Salario: {Salario.ToString("C")} TotalVendas: {TotalVendas.ToString("C")} MetaDeVendas: {MetaDeVendas.ToString("C")} QuantoFaltaMeta: {QuantoFaltaMeta().ToString("N2")}% SalarioFinal: {SalarioFinal.ToString("C")} ComissaoDasVendas: {ComissaoDasVendas().ToString("C")}";
    }
}
