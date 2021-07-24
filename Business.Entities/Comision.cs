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
            get => default;
            set
            {
            }
        }

        public String Descripcion
        {
            get => default;
            set
            {
            }
        }

        public int IdPlan
        {
            get => default;
            set
            {
            }
        }
    }
}