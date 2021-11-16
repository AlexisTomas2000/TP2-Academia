using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class ComPlan
    {
        private int _AñoEspecialidad, _ID;
        private String _Descripcion, _Descripcionp;
        private int _IDPlan;

        public int ID { get=>_ID; set=>_ID=value; }
        public int AnioEspecialidad
        {
            get => _AñoEspecialidad;
            set
            {
                _AñoEspecialidad = value;
            }
        }

        public String Descripcion
        {
            get => _Descripcion;
            set
            {
                _Descripcion = value;
            }
        }

        public int IdPlan
        {
            get => _IDPlan;
            set
            {
                _IDPlan = value;
            }
        }
        public String DescripcionP
        {
            get => _Descripcionp;
            set => this._Descripcionp = value;

        }
    }
}
