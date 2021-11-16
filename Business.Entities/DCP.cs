using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class DCP
    {
        private int _Cargo, id;
        private int _IDCurso;
        private int _IDDocente;
        private string _descMateria, _desc_Comision, _nombre, _apellido;

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
        public string Apellido { get => _apellido; set => _apellido = value;}
    public int ID { get => id; set => id = value; }
        public string DescMateria { get => _descMateria; set => _descMateria = value; }
        public string Desc_Comision { get => _desc_Comision; set => _desc_Comision = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        
    }
    
}
