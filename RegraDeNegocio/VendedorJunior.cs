﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Leandro_atividade2.RegraDeNegocio
{
    class VendedorJunior : Funcionario
    {
  
        public override double ComissaoDasVendas()
        {
            return TotalVendas* 0.04 ;
        }
    }
}
