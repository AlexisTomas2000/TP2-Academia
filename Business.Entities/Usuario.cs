using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Usuario : Persona
    {
        private String _NombreUsuario, _Clave;
        private bool _Habilitado;
        private int _idPersona;
        public String NombreUsuario{ get=>this._NombreUsuario; set=>this._NombreUsuario=value; }
        public String Clave { get=>this._Clave; set=>this._Clave=value; }
        public bool Habilitado { get =>this._Habilitado; set =>this._Habilitado=value; }
        public int IdPersona { get => _idPersona; set => _idPersona = value; }
    }
}
