using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class Modulo : BusinessEntity
    {
        private String _Descripcion;
        public String Descripcion { get =>this._Descripcion; set =>this._Descripcion = value; }
    }
}
