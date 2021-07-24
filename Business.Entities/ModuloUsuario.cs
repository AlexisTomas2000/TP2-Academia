using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ModuloUsuario : BusinessEntity
    {
        private int _IDUsuario, _IDModulo;
        private bool _PermiteBaja, _PermiteAlta, _PermiteModificacion, _PermiteConsulta;
        public int IdUsuario { get=>this._IDUsuario; set => this._IDUsuario=value; }
        public int IdModulo { get => this._IDModulo; set => this._IDModulo=value; }
        public bool Permitebaja { get => this._PermiteBaja; set => this._PermiteBaja=value; }
        public bool PermiteAlta { get => this._PermiteAlta; set => this._PermiteAlta=value; }
        public bool PermiteMod { get => this._PermiteModificacion; set => this._PermiteModificacion=value; }
        public bool PermiteConsulta { get => this._PermiteConsulta; set => this._PermiteConsulta=value; }
    }
}
