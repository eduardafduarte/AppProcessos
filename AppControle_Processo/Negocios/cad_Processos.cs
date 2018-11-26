using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControle_Processo.Negocios
{
    class cad_Processos
    {
        private string requerente;
        private int cpf_requerente;
        private int tel_requerente;
        private string adv_requerente;
        private string requerido;
        private string adv_requerido;
        private DateTime dt_abertura;
        private int numero_pro;

        public string Requerente { get => requerente; set => requerente = value; }
        public int Cpf_requerente { get => cpf_requerente; set => cpf_requerente = value; }
        public int Tel_requerente { get => tel_requerente; set => tel_requerente = value; }
        public string Adv_requerente { get => Adv_requerente1; set => Adv_requerente1 = value; }
        public string Adv_requerente1 { get => adv_requerente; set => adv_requerente = value; }
        public string Requerido { get => requerido; set => requerido = value; }
        public string Adv_requerido { get => Adv_requerido1; set => Adv_requerido1 = value; }
        public string Adv_requerido1 { get => adv_requerido; set => adv_requerido = value; }
        public DateTime Dt_abertura { get => dt_abertura; set => dt_abertura = value; }
        public int Numero_pro { get => numero_pro; set => numero_pro = value; }
    }
}
