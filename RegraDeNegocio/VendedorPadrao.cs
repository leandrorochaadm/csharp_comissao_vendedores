using System;
using System.Collections.Generic;
using System.Text;

namespace Leandro_atividade2.RegraDeNegocio
{
    class VendedorPadrao : Funcionario
    {
  
        public override double ComissaoDasVendas()
        {
            return TotalVendas* 0.06 ;
        }
    }
}
