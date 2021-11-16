using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class PlanEsp
    {
        private String _Descripcion,_DescripcionE;
        private int _IDEspecialidad,_id;

        public String Descripcion
        {
            get => _Descripcion;
            set => this._Descripcion = value;

        }

        public int IDEspecialidad
        {
            get => _IDEspecialidad;
            set => this._IDEspecialidad = value;
        }
        public int ID { get => _id; set => _id = value; }
        public String DescripcionE
        {
            get => _DescripcionE;
            set => this._DescripcionE = value;

        }

    }
}
