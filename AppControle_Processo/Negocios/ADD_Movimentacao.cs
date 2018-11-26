using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControle_Processo.Negocios
{
    class ADD_Movimentacao: cad_Processos
    {
        private DateTime dt_movi;
        private int numero_pro;
        private string movimentacao;

        public DateTime Dt_movi { get => dt_movi; set => dt_movi = value; }
        public int Numero_pro1 { get => numero_pro; set => numero_pro = value; }
        public string Movimentacao { get => movimentacao; set => movimentacao = value; }
    }
}
