using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class DocenteCurso : BusinessEntity
    {
        private int _Cargo;
        private int _IDCurso;
        private int _IDDocente;

        public int Cargo
        {
            get => this._Cargo;
            set => this._Cargo = value;
        }

        public int IDCurso
        {
            get => this._IDCurso;
            set => this._IDCurso = value;
        }

        public int IDDocente
        {
            get => this._IDDocente;
            set => this._IDDocente = value;
        }
    }
}