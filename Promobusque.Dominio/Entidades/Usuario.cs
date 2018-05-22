using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promobusque.Dominio
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string senhaMD5 { get; set; }
    }
}
