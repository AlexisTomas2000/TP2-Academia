using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class MatPlan
    {
        private String _Descripcion, _DescripcionP;
        private int _HsSemanales,_id;
        private int _HsTotales;
        private int _IDPlan;

        public String Descripcion
        {
            get => this._Descripcion;
            set => this._Descripcion = value;
        }
        public String DescripcionP
        {
            get => this._DescripcionP;
            set => this._DescripcionP = value;
        }

        public int HsSemanales
        {
            get => this._HsSemanales;
            set => this._HsSemanales = value;
        }

        public int HsTotales
        {
            get => this._HsTotales;
            set => this._HsTotales = value;
        }

        public int IDPlan
        {
            get => this._IDPlan;
            set => this._IDPlan = value;
        }
        public int ID { get => _id; set => _id = value; }
    }
}
