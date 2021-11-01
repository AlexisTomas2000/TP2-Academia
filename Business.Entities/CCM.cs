using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{
    public class CCM
    {
        int _Id_Curso, _Id_Materia, _Id_Comision,_Cupo,_Anio;
        String desc,_Desc_Materia, _DescComision;

        public int Id_Curso { get => _Id_Curso; set => _Id_Curso = value; }
        public int Id_Materia { get => _Id_Materia; set => _Id_Materia = value; }
        public int Id_Comision { get => _Id_Comision; set => _Id_Comision = value; }
        public string Desc { get => desc; set => desc = value; }
        public int Cupo { get => _Cupo; set => _Cupo = value; }
        public int Anio { get => _Anio; set => _Anio = value; }
        public string Desc_Materia { get => _Desc_Materia; set => _Desc_Materia = value; }
        public string DescComision { get => _DescComision; set => _DescComision = value; }
    }
}
