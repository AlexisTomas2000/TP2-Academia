using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : BusinessEntity
    {
        private String _NombreUsuario, _Clave, _Nombre, _Apellido, _Email;
        private bool _Habilitado;
        public String NombreUsuario{ get=>this._NombreUsuario; set=>this._NombreUsuario=value; }
        public String Clave { get=>this._Clave; set=>this._Clave=value; }
        public String Nombre { get=>this._Nombre; set=>this._Nombre=value; }
        public String Apellido { get=>this._Apellido; set=>this._Apellido=value; }
        public String Email  { get=>this._Email; set =>this._Email=value; }
        public bool Habilitado { get =>this._Habilitado; set =>this._Habilitado=value; }
    }
}
