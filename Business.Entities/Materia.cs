using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Materia : BusinessEntity
    {
        private String _Descripcion;
        private int _HsSemanales;
        private int _HsTotales;
        private int _IDPlan;

        public String Descripcion
        {
            get => this._Descripcion;
            set => this._Descripcion = value;
        }

        public int HsSemanales
        {
            get => this._HsSemanales;
            set => this._HsSemanales = value;
        }

        public int HsTotales
        {
            get => this._HsTotales;
            set => this._HsTotales=value;
        }

        public int IDPlan
        {
            get => this._IDPlan;
            set => this._IDPlan=value;
        }
    }
}