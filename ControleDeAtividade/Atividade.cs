using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeAtividade
{
    class Atividade
    {

        public int id { get; set; }
        public string titulo { get; set; }
        public string categoria { get; set; }

        public DateTime data_inicio { get; set; }
        public DateTime data_fim { get; set; }
        public string status { get; set; }
    }
}
