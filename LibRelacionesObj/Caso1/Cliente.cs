using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibRelacionesObj.UsuarioCliente
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Password { get; set; }    
        public Usuario usuario { get; set; }
    }
}
