using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Plan : BusinessEntity
    {
        private String _Descripcion, _DescripcionE;
        private int _IDEspecialidad;

        public String Descripcion
        {
            get => _Descripcion;
            set =>this._Descripcion = value;
            
        }

        public int IDEspecialidad
        {
            get => _IDEspecialidad;
            set => this._IDEspecialidad = value;
        }
        public String DescripcionE
        {
            get => _DescripcionE;
            set => this._DescripcionE = value;

        }
    }
}