using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleClinicaEstetica.Models
{
    public class AgendarClientes
    {
        public int IdAgendamento { get; set; }
        public string Nome_do_Cliente { get; set; }
        public string Tipo_de_Procedimento { get; set; }

        public DateTime Data_da_Realizacao { get; set; }
        public decimal Valor_do_procedimento { get; set; }
    }
}