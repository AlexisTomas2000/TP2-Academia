using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Comision : BusinessEntity
    {
        private int _AñoEspecialidad;
        private String _Descripcion;
        private int _IDPlan;

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
            _Descripcion= value;
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
    }
}