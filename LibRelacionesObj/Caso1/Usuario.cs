using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesObj.UsuarioCliente
{
    public class Usuario
    {
        public string Nombre { get; set; }  
        public string Apellido { get; set; }
        public Cliente cliente { get; set; }
    }
}
