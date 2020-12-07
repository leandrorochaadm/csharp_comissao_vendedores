using System;
using System.Collections.Generic;
using System.Text;

namespace Leandro_atividade2.RegraDeNegocio
{
    class SupervisorDeVendas : Funcionario
    {
        public double TotalVendasConc{get; set;}

        public double MetasDeVendasConc { get; set; }

        public new void CalcularSalarioFinal()
        {
            if (TotalVendas >= (MetaDeVendas * 0.65))
            {
                SalarioFinal = Salario + ComissaoDasVendas();
            }  
            else
                SalarioFinal = Salario;

            if(TotalVendasConc >= (MetasDeVendasConc * 0.65))
            {
                SalarioFinal += TotalVendasConc * 0.01;
            }
        }

        public override double ComissaoDasVendas()
        {
            return TotalVendas* 0.10 ;
        }

        public override string ToString() => base.ToString() + $" TotalVendasConc: {TotalVendasConc.ToString("C")} MetasDeVendasConc: {MetasDeVendasConc.ToString("C")}";
    }
}
