using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Curso: BusinessEntity
    {
        private int _AnioCalendario;
        private int _Cupo;
        private int _IDComision;
        private int _ID_Materia;
        private string _DescComision, _Desc_Materia, desc;

        public int AnioCalendario
        {
            get => this._AnioCalendario;
            set => this._AnioCalendario = value;
        }

        public int Cupo
        {
            get => this._Cupo;
            set => this._Cupo = value;
        }
        public int IDComision
        {
            get => this._IDComision;
            set => this._IDComision = value;
        }

        public int IDMateria
        {
            get => this._ID_Materia;
            set => this._ID_Materia = value;
        }
        public string Desc_Materia { get => _Desc_Materia; set => _Desc_Materia = value; }
        public string DescComision { get => _DescComision; set => _DescComision = value; }
        public string Desc { get => desc; set => desc = value; }
    }
}