﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Entities
{
    public class Especialidad: BusinessEntity
    {
        private String _Descripcion;

        public String Descripcion
        {
            get => this._Descripcion;
            set=>this._Descripcion = value;
        }
    }
}